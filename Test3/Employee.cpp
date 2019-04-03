#include"Employee.h"
using namespace std;

Employee::Employee(string name)
	{
		this->name = name;
	}

void Employee::company()
	{
		cout << co_name << endl;
	}

void Employee::info()
	{
		cout << "Name : " << name << endl;
		cout << "Company : " << co_name << endl << endl;
	}

const string Employee::co_name = "AUE";
