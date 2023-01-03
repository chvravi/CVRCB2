#include <stdio.h>

struct student
{
	int roll;
	char name[50];
	int sub[7],assign[7];
};

void main()
{
	int k,i;
	struct student s[10];
	clrscr();
	for(i=0;i<10;i++)
	{
		printf("Enter name: ");
		scanf("%s",s[i].name);
		printf("Enter roll number: ");
		scanf("%d",&s[i].roll);
		for(k=0;k<=6;k++)
		{
			printf("Enter Term-End Marks of Sub %d=",k+1);
			scanf("%d",&s[i].sub[k]);
			printf("Enter Assignment of Sub %d=",k+1);
			scanf("%d",&s[i].assign[k]);
		}
	}
	printf("\nDisplaying Information\n");
	for(i=0;i<10;i++)
	{
		printf("\n_____________________________________\n");
		printf("Roll Number :%d \t Name:%s \n",s[i].roll,s[i].name);
		printf("\n_____________________________________\n");
		for(k=0;k<=6;k++)
		{
			printf("TTE Marks:%d \t Assignment:%d\n", s[i].sub[k],s[i].assign[k]);
		}
	}
	getch();
}