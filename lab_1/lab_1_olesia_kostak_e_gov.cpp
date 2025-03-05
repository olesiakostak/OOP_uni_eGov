#include <iostream>
#include <string>
using namespace std;

class Person
{
protected:
    string name;
    string surname;
    int age;
public:
    Person() {}
    ~Person() {}
};
class TaxPayer
{
protected:
    double tax = 0;
    int salary;
};
class Citizen: public Person, public TaxPayer
{
protected:
    double social_assistance = 0;
    struct User
    {
        int work_experience;
        string profession;
    };
    User current_user;

public:
    Citizen() {}
    ~Citizen() {}
    virtual void Register();
    virtual void ShowUserInformation();
    virtual void CalculateSocialAssistance() = 0;
    virtual void CalculateTaxes() = 0;
};

class Student: public Citizen
{
public:
    Student() {}
    ~Student() {}
    void CalculateSocialAssistance() override;
    void CalculateTaxes() override;
};
class Employee: public Citizen
{
public:
    Employee() {}
    ~Employee() {}
    void CalculateSocialAssistance() override;
    void CalculateTaxes() override;
};
class Entrepreneur: public Citizen
{
public:
    using Citizen::Citizen;
    void CalculateSocialAssistance() override;
    void CalculateTaxes() override;
};




int main()
{
    Citizen* user = nullptr;
    int user_choice;

    cout << "You're welcome to our e-Government" << endl << endl;
    while (true)
    {
        cout << "Choose an option to continue (enter a number): " << endl;
        cout << "1. Register\n2. Calculate social assistance\n3. Calculate taxes\n4. Display information\n5. Exit \n"; 
        cin >> user_choice;

        if (!user && user_choice != 1) 
        {
            cout << endl << "You are not registered" << endl;
            continue;
        }
        switch (user_choice)
        {
            case 1:
                delete user;
                user = nullptr;
                cout << "Which category do you belong to (enter a number):\n1. Student. \n2. Employee. \n3. Enterpreneur. \n";
                int user_category;
                cin >> user_category;
                
                switch (user_category)
                {
                    case 1:
                        user = new Student();
                        break;
                    case 2:
                        user = new Employee();
                        break;
                    case 3:
                        user = new Entrepreneur();
                        break;
                    default:
                        cout << endl << "You have entered not correct data" << endl;
                        break;
                }
                if (user) user->Register();
                break;
            case 2:
                user->CalculateSocialAssistance();
                break;
            case 3:
                user->CalculateTaxes();
                break;
            case 4:
                user->ShowUserInformation();
                break;
            case 5:
                return 0;
            default:
                cout << endl << "You have entered not correct answer." << endl;
                break;
            }
    }
    delete user;
    return 0;
}

void Citizen::ShowUserInformation()
{
    cout << "Name and surname: " << name << " " << surname << endl;
    cout << "Age: " << age << endl;
    cout << "Profession: " << current_user.profession << endl;
    cout << "Salary: " << salary << endl;
    cout << "Work experience: " << current_user.work_experience << endl; 
    cout << "-----------Calculated data-----------" << endl;
    cout << "Social assistance: " << social_assistance << endl;
    cout << "Tax: " << tax << endl;
}
void Citizen::Register()
{
    cout << "Enter your \nName: "; 
    cin >> name;
    cout << "Surname: ";
    cin >> surname;
    cout << "Age: ";
    cin >> age;
    cout << "Profession: ";
    cin >> current_user.profession;
    cout << "Salary: ";
    cin >> salary;
    cout << "Work experience: ";
    cin >> current_user.work_experience;
}

void Student::CalculateSocialAssistance()
{
    cout << "Enter your degree:\n 1. Associate degree  2. Bachelor`s degree   3. Master`s degree  4. Doctoral degree  5. Professional degree\n";
    int degree;
    cin >> degree;
    switch (degree)
    {
    case 1:
        social_assistance += 35;
        break;
    case 2:
        social_assistance += 55;
        break;
    case 3:
        social_assistance += 70;
        break;
    case 4:
        social_assistance += 100;
        break;
    case 5:
        social_assistance += 150;
        break;
    default:
        cout << "You have entered not correct option" << endl;
        break;
    }
}
void Student::CalculateTaxes() {}

void Employee::CalculateTaxes()
{
    double income_tax = salary * 0.18;
    double military_tax = salary * 0.015; 
    tax = income_tax + military_tax;
}
void Employee::CalculateSocialAssistance() {}

void Entrepreneur::CalculateSocialAssistance() {}
void Entrepreneur::CalculateTaxes()
{
    tax = salary * 0.1;
}
