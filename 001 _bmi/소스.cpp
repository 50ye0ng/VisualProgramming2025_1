#include <stdio.h>

int main()
{
	//Ű�� ü���� �Է¹޾Ƽ�, bmi�� ����ϰ� ���
	double h; //Ű
	double w; //ü��

	printf("Ű(cm) : ");
	scanf_s("%lf", &h);

	printf("ü��(kg) : ");
	scanf_s("%lf", &w);

	h /= 100; //m���� ȯ��

	double bmi = w / (h * h);
	printf("bmi = %lf\n", bmi);
}