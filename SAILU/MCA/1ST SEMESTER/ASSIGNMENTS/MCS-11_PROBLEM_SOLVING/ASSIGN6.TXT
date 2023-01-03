#include <stdio.h>

void main()
{
	FILE *fp,*pp,*op;
	char ch,*s;
	clrscr();
	op=fopen("bcrypt.txt","w+r");
	fp=fopen("acrypt.txt","w");

	if(fp==NULL)
	{
		printf("file can not be open.\n");
		getch();
		exit();
	}

	printf("enter the Text :\n");
	gets(s);

	printf("\nBefore the transformation=%s\n",s);
	while(*s!=NULL)
	{
		fputc(*s,op);
		s++;
	}
	rewind(op);

	printf("\nAfter Transformation=");
	do
	{
		ch=fgetc(op);

		if(ch>='A' && ch<='Z')
		{
			if(ch=='Z')
			{
				ch='A';
			}
			else
			{
				ch=ch+1;
			}
		}
		else if(ch>='a' && ch<='z')
		{
			if(ch=='z')
			{
				ch='a';
			}
			else
			{
				ch=ch+1;
			}
		}
		putchar(ch);
		fputc(ch,fp);
	}while(ch!=eof());
	getch();
}