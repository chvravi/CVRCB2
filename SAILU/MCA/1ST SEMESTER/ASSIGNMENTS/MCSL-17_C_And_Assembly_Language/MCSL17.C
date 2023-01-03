#include <stdio.h>

struct student
{
	char Name[100];
	int Enrollment;
	char Programme[100];
	char Course[100];
	char Semester[50];
	char Address[500];
	char Contact[100];
	int Assignments[7]; /* Student has 7 Assignments */
	int Attendence[2]; /* Student has 2 Practical Courses */
};

void main()
{
	int StudentIndex,AssignmentIndex,AttendenceIndex;
	int NumberOfStudents = 0;
	struct student s[10]; /* Consider Maximum Number of students are 10 */
	printf("Enter No Of Students: ");
	scanf("%d",&NumberOfStudents);
	clrscr();

	for(StudentIndex=0;StudentIndex<NumberOfStudents;StudentIndex++)
	{
		printf("Please Enter Details of %d Student \n", StudentIndex+1);
		printf("Enter Name: ");
		scanf("%s",s[StudentIndex].Name);
		printf("Enter Enrollment number: ");
		scanf("%d",&s[StudentIndex].Enrollment);
		printf("Enter Programme: ");
		scanf("%s",s[StudentIndex].Programme);
		printf("Enter Course: ");
		scanf("%s",s[StudentIndex].Course);
		printf("Enter Semester: ");
		scanf("%s",s[StudentIndex].Semester);
		printf("Enter Address: ");
		scanf("%s",s[StudentIndex].Address);
		printf("Enter Contact: ");
		scanf("%s",s[StudentIndex].Contact);
		for(AssignmentIndex=0;AssignmentIndex<7;AssignmentIndex++)
		{
			printf("Enter Assignment Marks of Sub %d = ", AssignmentIndex+1);
			scanf("%d",&s[StudentIndex].Assignments[AssignmentIndex]);
		}
		for(AttendenceIndex=0;AttendenceIndex<2;AttendenceIndex++)
		{
			printf("Enter Attendence of Sub %d = ",AttendenceIndex+1);
			scanf("%d",&s[StudentIndex].Attendence[AttendenceIndex]);
		}
	}

	printf("\nDisplaying Information\n");

	for(StudentIndex=0;StudentIndex<NumberOfStudents;StudentIndex++)
	{
		printf("Details of %d Student \n", StudentIndex+1);
		printf("\n_____________________________________\n");
		printf("Roll Number :%d \t Name:%s \n",s[StudentIndex].Enrollment, s[StudentIndex].Name);
		printf("Programme :%s \t Course:%s Semester :%s \n",s[StudentIndex].Programme, s[StudentIndex].Course, s[StudentIndex].Semester);
		printf("Address :%s \t Contact:%s \n",s[StudentIndex].Address, s[StudentIndex].Contact);
		printf("\n_____________________________________\n");
		for(AssignmentIndex=0;AssignmentIndex<7;AssignmentIndex++)
		{
			printf("Assignment Marks:%d for Subject : %d\n", s[StudentIndex].Assignments[AssignmentIndex], AssignmentIndex+1);
		}
		for(AttendenceIndex=0;AttendenceIndex<2;AttendenceIndex++)
		{
			printf("Attendence in Practical Course:%d for Subject : %d\n", s[StudentIndex].Attendence[AttendenceIndex], AttendenceIndex+1);
		}
	}
	getch();
}