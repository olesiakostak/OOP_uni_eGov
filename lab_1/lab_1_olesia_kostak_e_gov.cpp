#include <iostream>
#include <string>
using namespace std;

class Citizen
{
protected:
    string filename = "user_data.txt";
    int social_assistance = 0;
    int tax = 0;
    struct User
    {
        int age;
        int work_experience;
        int salary;
        string name;
        string surname;
        string profession;
    };
    User current_user;

public:
    Citizen() {}
    void Register();
    void ShowUserInformation();
    void CalculateSocialAssistance() {};
    void CalculateTaxes() {};
};

class Student: public Citizen 
{
public:
    using Citizen::Citizen;
    void CalculateSocialAssistance();
    void CalculateTaxes();
};
class Employee: public Citizen 
{
public:
    using Citizen::Citizen;
    void CalculateSocialAssistance();
    void CalculateTaxes();
};
class Entrepreneur: public Citizen 
{
public:
    using Citizen::Citizen;
    void CalculateSocialAssistance();
    void CalculateTaxes();
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
                        delete user;
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
    cout << "Name and surname: " << current_user.name << " " << current_user.surname << endl;
    cout << "Age: " << current_user.age << endl;
    cout << "Profession: " << current_user.profession << endl;
    cout << "Work experience: " << current_user.work_experience << endl; 
    cout << "Calculated data: " << endl;
    cout << "Social assistance: " << social_assistance << endl;
    cout << "Tax: " << tax << endl;
}
void Citizen::Register()
{
    cout << "Enter your \nName: "; 
    cin >> current_user.name;
    cout << "Surname: ";
    cin >> current_user.surname;
    cout << "Age: ";
    cin >> current_user.age;
    cout << "Profession: ";
    cin >> current_user.profession;
    cout << "Salary: ";
    cin >> current_user.salary;
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
    double income_tax = current_user.salary * 0.18;
    double military_tax = current_user.salary * 0.15; 
    tax = income_tax + military_tax;
}
void Employee::CalculateSocialAssistance() {}

void Entrepreneur::CalculateSocialAssistance() {}
void Entrepreneur::CalculateTaxes()
{
    tax = current_user.salary * 0.1;
}
