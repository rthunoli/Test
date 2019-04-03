#include<iostream>
#include<string>

using namespace std;

class Employee
{
	static const string co_name;
	string name;

public:
	Employee(string name);
	static void company();
	void info();
	
};
