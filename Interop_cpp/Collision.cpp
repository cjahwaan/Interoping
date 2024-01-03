#include "Functions.h"

bool Functions::CheckcollisionRect(Rect& a, Rect& b)
{
	if (a.x + a.width >= b.x &&     // r1 right edge past r2 left
		a.x <= b.x + b.width &&       // r1 left edge past r2 right
		a.y + a.height >= b.y &&       // r1 top edge past r2 bottom
		a.y <= b.y + b.height) {       // r1 bottom edge past r2 top
		return true;
	}

	return false;
}


bool Functions::CheckcollisionPoint(Point& a, Rect& b)
{
	if (a.x < b.x || a.x > b.x + b.width)
		return false;

	if (a.y < b.y || a.y > b.y + b.height)
		return false;

	return true;
}