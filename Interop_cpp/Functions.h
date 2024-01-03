#pragma once
#include <iostream>

#define API __declspec(dllexport)

namespace Functions
{
	struct Point
	{
		int x, y;
	};

	struct Rect
	{
		int x, y;
		int width, height;
	};

	void NoneExternalPrint();

	extern "C" 
	{
		API void Print();
		API int Add(int a, int b);
		API float Addf(float a, float b);
		API bool CheckcollisionPoint(Point& a, Rect& b);
		API bool CheckcollisionRect(Rect& a, Rect& b);
	}
}
