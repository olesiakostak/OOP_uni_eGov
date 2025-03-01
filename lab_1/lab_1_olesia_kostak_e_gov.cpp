#include <iostream>
#include <string>
using namespace std;

class Citizen
{
private:
    string name;
    int age;

public:

};

class Student: public Citizen {};
class Employee: public Citizen {};
class Entrepreneur: public Citizen {};

int main()
{


    return 0;
}