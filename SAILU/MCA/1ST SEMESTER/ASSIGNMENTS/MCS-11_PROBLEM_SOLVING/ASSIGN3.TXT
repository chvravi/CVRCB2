#include<stdio.h>
main()
{
	FILE *fp,*pp;
	char ch,*s,*output;
	clrscr();
	printf("Enter the Input File name : \n");
	gets(s);
	fp=fopen(s,"r");
	printf("Enter the Output File name : \n");
	gets(output);
	pp=fopen(output,"w");
	if(fp==NULL)
	{
		printf("file can not be opened. \n");
		getch();
		exit();
	}
	while(ch!=eof())
	{
		ch=fgetc(fp);
		putchar(ch);
		fputc(ch,pp);
	}
	getch();
	return 0;
}