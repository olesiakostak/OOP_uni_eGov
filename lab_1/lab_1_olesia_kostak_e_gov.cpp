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
            /* code */
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
    cout << "Name: " << name << endl;
    cout << "Age: " << age << endl; 
}
void Citizen::Register()
{
    cout << "Enter your \n Name: "; 
    cin >> name;
    cout << "\n Surname: ";
    cin >> surname;
    cout << "\n Age: ";
    cin >> age;
    cout << "\n Profession: ";
    cin >> progession;

    cin >> 


}