/*
*   GeneticAssigner - Genetic Algorithm implementation for automatic 
*   assigning of students to class courses.
*   Copyright (C) 2008-2011  Rodrigo Queipo <rodrigoq@gmail.com>
*
*   This program is free software: you can redistribute it and/or modify
*   it under the terms of the GNU General Public License as published by
*   the Free Software Foundation, either version 3 of the License, or
*   (at your option) any later version.
*
*   This program is distributed in the hope that it will be useful,
*   but WITHOUT ANY WARRANTY; without even the implied warranty of
*   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*   GNU General Public License for more details.
*
*   You should have received a copy of the GNU General Public License
*   along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;

namespace DataFactory
{
	public class Student: Identifiable
	{

		internal Student(int id, string name, params int[] options)
		{
			this.id = id;
			this.name = name;
			this.options = options;
			this.UnAssign();
		}

		int[] options;
		string name;
		int id;
		int assignedCourse;
		int assignedOption;

		public int Id
		{
			get { return id; }
		}
		public int[] Options
		{
			get { return options; }
		}
		public string Name
		{
			get { return name; }
		}
		public int AssignedCourse
		{
			get { return assignedCourse; }
		}
		public bool Assigned
		{
			get { return assignedCourse != 0; }
		}
		public int AssignedOption
		{
			get { return assignedOption; }
		}

		public void AssignOption(int option)
		{
			assignedOption = option;
			assignedCourse = options[option];
		}

		internal void UnAssign()
		{
			assignedCourse = 0;
			assignedOption = -1;
		}

		public override string ToString()
		{
			string options = "";
			for(int i = 0;i < Options.Length;i++)
			{
				if(Assigned && AssignedOption == i)
					options += "[" + Options[i] + "] ";
				else
					options += Options[i] + " ";
			}
			return Id + " | " + Name + " | " + options.Trim();
		}

		internal Student Clone()
		{
			Student student = new Student(this.id, this.name, new int[this.options.Length]);
			Array.Copy(this.options, student.options, this.options.Length);
			student.assignedCourse = this.assignedCourse;
			student.assignedOption = this.assignedOption;

			return student;
		}

	}
}
