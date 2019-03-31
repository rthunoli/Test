#include <iostream>
#include <string>
#include <vector>
using namespace std;

class Number2Word
{
	struct NumWord
	{
		int number;
		string word;
	};

	vector<NumWord>NW;

public:
	Number2Word()
	{
		NW.push_back({ 0,"zero" });
		NW.push_back({ 1,"one" });
		NW.push_back({ 2,"two" });
		NW.push_back({ 3,"three" });
		NW.push_back({ 4,"four" });
		NW.push_back({ 5,"five" });
		NW.push_back({ 6,"six" });
		NW.push_back({ 7,"seven" });
		NW.push_back({ 8,"eight" });
		NW.push_back({ 9,"nine" });
		NW.push_back({ 10,"ten" });
	}

	void printWord(int no)
	{
		for(NumWord nw : NW)
			if (no == nw.number)
			{
				cout << nw.word << endl;
				return;
			}
		cout << "Number not found" << endl;
	}
};
