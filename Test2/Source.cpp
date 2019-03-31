#include <iostream>
#include <string>
#include "Header.h"
using namespace std;

int main()
{

	string no;
	while (true)
	{
		cout << "Enter a number (0-10) : ";
		cin >> no;
		if (no == "q")
			break;
		Number2Word oN2w;
		oN2w.printWord(stoi(no));
		cout << endl;
	}
	//system("pause");
	return 0;
}

