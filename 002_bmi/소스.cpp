#include <iostream>
using namespace std;

int main()
{
	double weight, height;

	cout << "ü��(km) : ";
	cin >> weight;

	cout << "Ű(cm) : ";
	cin >> height;

	double bmi = weight / (height / 100) / (height / 100);
	cout << "BMI = " << bmi << endl;
}