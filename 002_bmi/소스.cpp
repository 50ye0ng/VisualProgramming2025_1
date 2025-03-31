#include <iostream>
using namespace std;

int main()
{
	double weight, height;

	cout << "Ã¼Áß(km) : ";
	cin >> weight;

	cout << "Å°(cm) : ";
	cin >> height;

	double bmi = weight / (height / 100) / (height / 100);
	cout << "BMI = " << bmi << endl;
}