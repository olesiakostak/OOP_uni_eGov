#include <iostream>
#include <string>
using namespace std;

class Citizen
{
protected:
    string filename = "user_data.txt";

    struct User
    {
        int age;
        int work_experience;
        string name;
        string surname;
        string profession;
    };
    User current_user;

public:
    Citizen() {}
    void Register();
    void ShowUserInformation();
};

class Student: public Citizen 
{
public:
    using Citizen::Citizen;
};
class Employee: public Citizen 
{
public:
    using Citizen::Citizen;
};
class Entrepreneur: public Citizen 
{
public:
    using Citizen::Citizen;
};




int main()
{
    Citizen* user = nullptr;
    cout << "You're welcome to our e-Government" << endl << endl;
    int user_choice;
    while (true)
    {
        cout << "Choose an option to continue (enter a number): " << endl;
        cout << "1. Register\n2. Show my information\n2. Find out social assistance\n3. Calculate taxes\n4. Exit \n"; 
        cin >> user_choice;
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
                        cout << "You have entered not correct data";
                        break;
                }
                if (user)
                {
                    user->Register();
                }
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                cout << "You have entered not correct answer.";
                break;
            }
            break;
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
    cout << "Work experience: ";
    cin >> current_user.work_experience;
}


// current_user.age = user_age;
//         current_user.work_experience = user_work_experience;
//         current_user.name = user_name;
//         current_user.surname = user_surname;
//         current_user.profession = user_profession;   