#include "Functions.h"

int Functions::Add(int a, int b)
{
	return a + b;
}

float Functions::Addf(float a, float b)
{
	return a + b;
}

void Functions::Print()
{
	NoneExternalPrint();
	std::cout << "Now this is programming in c++\n";
}

void Functions::NoneExternalPrint()
{
	std::cout << "Non-External Print\n";
}
