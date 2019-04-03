#include<iostream>
#include<string>
using namespace std;

class Employee
{
	static const string co_name;
	string name;

public:
	Employee(string name)
	{
		this->name = name;
	}
	
	static void company()
	{
		cout << co_name << endl;
	}

	void info()
	{
		cout << "Name : " << name << endl;
		cout << "Company : " << co_name << endl << endl;
	}
};

const string Employee::co_name = "AUE";

int main()
{
	Employee("Raj").info();
	Employee("Saleha").info();
	Employee::company();

	system("pause");
	return 0;
}