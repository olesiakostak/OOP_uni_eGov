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
    User user;

public:
    Citizen(string user_name, int user_age)
    {
        user.name = user_name;
        user.age = user_age;
    }
    void Register();
    void ShowUserInformation();
};

class Student: public Citizen 
{
private:

public:
    using Citizen::Citizen;
};
class Employee: public Citizen {};
class Entrepreneur: public Citizen {};




int main()
{
    cout << "You're welcome to our e-Government" << endl << endl;
    int user_choice;
    while (true)
    {
        cout << "Choose an option to continue (enter a number): " << endl;
        cout << "1. Register \n 2. Find out social assistance \n 3. Calculate taxes \n 4. Exit \n"; 
        cin >> user_choice;
        switch (user_choice)
        {
            case '1':
                "Which category you belong to (enter a number): \n 1. Student. \n 2. Employee. \n 3. Enterpreneur. \n";
                int user_category;
                cin >> user_category;
                switch (user_category)
                {
                    case '1':
                    Employee user;
                    user.Register();
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    default:
                        break;
                }
                break;
            case '2':
                break;
            case '3':
                break;
            case '4':
                break;
            default:
                cout << "You have entered not correct answer.";
                break;
            }
            break;
    }
    Student ct("f", 3);
    ct.ShowUserInformation();
    return 0;
}

void Citizen::ShowUserInformation()
{
    cout << "Name: " << user.name << endl;
    cout << "Age: " << user.age << endl; 
}
void Citizen::Register()
{
    cout << "Enter your \n Name: "; 
    cin >> user.name;
    cout << "\n Surname: ";
    cin >> user.surname;
    cout << "\n Age: ";
    cin >> user.age;
    cout << "\n Profession: ";
    cin >> user.profession;
    cout << "\n Work experience: ";
    cin >> user.work_experience;

    cin >> 


}