﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06CentroEscolar
{
    public partial class fStudents : Form
    {
        public fStudents()
        {
            InitializeComponent();
        }
        public CourseList courseList;
        public StudentList studentList;

        public fStudents(CourseList courseList, StudentList studentList)
        {
            InitializeComponent();
            this.courseList = courseList;
            this.studentList = studentList;
        }
        // Students Buttons
        // Add button
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!courseList.IsEmpty())
            {
                DialogResult addMoreStudents = DialogResult.Yes;
                while (addMoreStudents == DialogResult.Yes)
                {
                    bool wasAdded = false;
                    Student new_student = new Student();
                    string name = Interaction.InputBox("Add a name to the student please");
                    if (!name.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(name))
                    {
                        string dni = Interaction.InputBox("Add an ID to the student please");
                        if ((dni.Length == 10 || dni.Length == 9) && !studentList.IsIDInList(dni))
                        {
                            string phoneNumber = Interaction.InputBox("Add a phone number to the student");
                            if (phoneNumber.Length >= 9 && phoneNumber.Length <= 13)
                            {
                                string courseCode = Interaction.InputBox("Add the student into a course").ToUpper();
                                if (courseList.GetIndexByCode(courseCode) != -1)
                                {
                                    new_student.Name = name;
                                    new_student.Dni = dni;
                                    new_student.PhoneNumber = phoneNumber;
                                    new_student.CourseCode = courseCode.ToUpper();
                                    studentList.AddStudentToList(new_student);
                                    wasAdded = true;
                                    MessageBox.Show("Student was added");
                                
                                } else
                                {
                                    MessageBox.Show("That course doesn't exist.");
                                }
                            } else
                            {
                                MessageBox.Show("A phone number must have between 9 and 13 chars.");
                            }
                        } else
                        {
                            MessageBox.Show("That student's DNI/NIE already exist or format is not correct.");
                        }
                    } else
                    {
                        MessageBox.Show("That name isn't correct.");
                    }
                    if (wasAdded)
                    {
                        addMoreStudents = MessageBox.Show("Do you want to add anothe student?", " ", MessageBoxButtons.YesNo);
                    } else
                    {
                        MessageBox.Show("Try again!");
                    }
                } 
            } else
            {
                MessageBox.Show("There's no courses. Please add one before adding a student.");
            }
        }
        // Delete button
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (!studentList.IsEmpty())
            {
                string dni = Interaction.InputBox("Write the student's DNI/NIE.").ToUpper();
                int index = studentList.GetIndexByDNI(dni);
                if (index != -1)
                {
                    studentList.RemoveStudentFromList(index);
                    MessageBox.Show("Student removed.");
                }
                else
                {
                    MessageBox.Show("That student doesn't exist.");
                }
            } else
            {
                MessageBox.Show("There's no students in the list yet.");
            }
        }
        // Show methods
        private void btnShowStudentData_Click(object sender, EventArgs e)
        {
            if (!studentList.IsEmpty())
            {
                string studentInfo = "That student doesn't exist";
                string dni = Interaction.InputBox("Write the student's DNI/NIE.");
                int index = studentList.GetIndexByDNI(dni);
                if (index != -1)
                {
                    studentInfo = studentList.ShowStudentAtIndex(index);
                }
                MessageBox.Show(studentInfo);
            } else
            {
                MessageBox.Show("There's no students in the list yet.");
            }
        }

        private void btnShowStudentList_Click(object sender, EventArgs e)
        {
            if (!studentList.IsEmpty())
            {
                string studentsText = studentList.ShowEveryStudent();
                MessageBox.Show(studentsText);
            } else
            {
                MessageBox.Show("There's no students in the list yet.");
            }
        }

        private void btnShowStudentsFromCourse_Click(object sender, EventArgs e)
        {
            if (!courseList.IsEmpty())
            {
                string studentsInCourse = "The course doesn't exist";
                string courseCode = Interaction.InputBox("What course's students do you want to see?");
                int index = courseList.GetIndexByCode(courseCode);

                if (index != -1)
                {
                    if (studentList.ShowEveryStudentInCourse(courseCode) != "")
                    {
                        studentsInCourse = "The students in " + courseCode.ToUpper() + " are: \n";
                        studentsInCourse += studentList.ShowEveryStudentInCourse(courseCode);

                    }
                    else
                    {
                        studentsInCourse = "The course is empty";
                    }
                }
                MessageBox.Show(studentsInCourse);
            }
            else
            {
                MessageBox.Show("No courses were added yet.");
            }
        }
        // Order methods
        private void btnOrderByName_Click(object sender, EventArgs e)
        {
            if (!studentList.IsEmpty())
            {
                if (studentList.OrderByName())
                {
                    MessageBox.Show("Students Ordered");
                } else
                {
                    MessageBox.Show("There's not more than one students in the list.");
                }
            } else
            {
                MessageBox.Show("The list is Empty. No students were added yet.");
            }
        }

        // Grades Buttons
        // Add Grades
        private void btnAddGrades_Click(object sender, EventArgs e)
        {
            if (!studentList.IsEmpty())
            {
                DialogResult addMoreGrades = DialogResult.Yes;
               
                string dni = Interaction.InputBox("Write the DNI/NIE from the student that you want to add a grade");
                DialogResult addToSameStudent = DialogResult.Yes;
                while (addMoreGrades == DialogResult.Yes)
                {
                    
                    if (addToSameStudent == DialogResult.No)
                    {
                        dni = Interaction.InputBox("Write the DNI/NIE from the student that you want to add a grade");
                    }
                    int index = studentList.GetIndexByDNI(dni);
                    if (index != -1)
                    {

                        double grade = double.Parse(Interaction.InputBox("Add a grade"));
                    
                        if (grade >= 1 && grade <= 10)
                        {
                            studentList.AddGradeToStudent(index, grade);
                             
                            MessageBox.Show("Grade Added!");
                            addToSameStudent = MessageBox.Show("Do you want to add more grades to the same student?", "", MessageBoxButtons.YesNo);
                            if (addToSameStudent == DialogResult.No)
                            {
                                addMoreGrades = MessageBox.Show("Do you want to add more grades?", "", MessageBoxButtons.YesNo);
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("That grade is not between 1 and 10");
                            addToSameStudent = DialogResult.Yes;
                        } 
                    } else
                    {
                        MessageBox.Show("That student doesn't exist.");
                        addToSameStudent = DialogResult.No;
                    }
                }
            } else
            {
                MessageBox.Show("There's no students in the list yet.");
            }
        }
        // Delete Grades
        private void btnDeleteGrades_Click(object sender, EventArgs e)
        {
            if (!studentList.IsEmpty())
            {
                DialogResult deleteFromMoreStudents = DialogResult.Yes;
                while (deleteFromMoreStudents == DialogResult.Yes)
                {
                    string dni = Interaction.InputBox("Write the DNI/NIE from the student whose grades you want to delete");

                    if (studentList.DeleteGradesFromStudent(dni))
                    {
                        MessageBox.Show("Grades deleted");
                    }
                    else
                    {
                        MessageBox.Show("That student doesn't exist");
                    }
                    deleteFromMoreStudents = MessageBox.Show("Do you want to delete the grades from another student?", "", MessageBoxButtons.YesNo);
                }
            } else
            {
                MessageBox.Show("There's no students in the list yet.");
            }
        }
        // Show methods
        private void btnShowStudentsWithAVGUpperThan5_Click(object sender, EventArgs e)
        {
            if (!studentList.IsEmpty())
            {
                string students = studentList.ShowStudentsAVGMore5();
                MessageBox.Show(students);
            } else
            {
                MessageBox.Show("The list of students is empty yet.");
            }
        }

        private void btnShowStudentsWithAVGLessThan5_Click(object sender, EventArgs e)
        {
            if (!studentList.IsEmpty())
            {
                string students = studentList.ShowStudentsAVGLess5();
                MessageBox.Show(students);
            }
            else
            {
                MessageBox.Show("The list of students is empty yet.");
            }
        }

    }
}
