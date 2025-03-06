#include <iostream>
#include <string>
using namespace std;

class Person
{
protected:
    int age;
    string name;
    string surname;
public:
    Person() {}
    ~Person() {}
};
class TaxPayer
{
protected:
    struct Worker
    {
        double tax = 0;
        int salary;
        int work_experience;
        string profession;    
    };
    Worker current_worker;
};
class Citizen: public Person, public TaxPayer
{
protected:
    double social_assistance = 0;
    bool is_work;

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

    cout << "You're welcome to our e-Government" << endl << endl;
    while (true)
    {
        cout << "Choose an option to continue (enter a number): " << endl;
        cout << "1. Register\n2. Calculate social assistance\n3. Calculate taxes\n4. Display information\n5. Exit \n"; 
        int user_choice;
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
    cout << "Social assistance: " << social_assistance << endl;

    if (is_work)
    {
        cout << "Profession: " << current_worker.profession << endl;
        cout << "Salary: " << current_worker.salary << endl;
        cout << "Work experience: " << current_worker.work_experience << endl; 
        cout << "Tax: " << current_worker.tax << endl;
    }
    else
    {
        cout << "Work: unemployed" << endl;
    }
}
void Citizen::Register()
{
    cout << "Enter your \nName: "; 
    cin >> name;
    cout << "Surname: ";
    cin >> surname;
    cout << "Age: ";
    cin >> age;
    cout << "Do you have work? (enter y/n) ";
    char current_choice;
    cin >> current_choice;
    if (current_choice == 'y') is_work = true;
    else is_work = false;
    if (is_work)
    {
        cout << "Profession: ";
        cin >> current_worker.profession;
        cout << "Salary: ";
        cin >> current_worker.salary;
        cout << "Work experience: ";
        cin >> current_worker.work_experience;
    }
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
void Student::CalculateTaxes() 
{
    cout << "You cannot calculate tax because you're category doesn't allow this" << endl;
}

void Employee::CalculateTaxes()
{
    if (!is_work) 
    {
        cout << "Your're unemplyed so you cannot calculate tax" << endl; 
        return;
    }
    double income_tax = current_worker.salary * 0.18;
    double military_tax = current_worker.salary * 0.015; 
    current_worker.tax = income_tax + military_tax;
}
void Employee::CalculateSocialAssistance() 
{
    cout << "You cannot calculate social assistance because you're category doesn't allow this" << endl;
}

void Entrepreneur::CalculateSocialAssistance() 
{
    cout << "You cannot calculate social assistance because you're category doesn't allow this" << endl;
}
void Entrepreneur::CalculateTaxes()
{
    if (!is_work) 
    {
        cout << "Your're unemplyed so you cannot calculate tax" << endl; 
        return;
    }
    current_worker.tax = current_worker.salary * 0.1;
}
