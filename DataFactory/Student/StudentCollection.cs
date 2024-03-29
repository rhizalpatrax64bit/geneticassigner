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

namespace DataFactory
{
	public class StudentCollection: Collection<Student>
	{
		public int MaxOptions { get; set; }

		public StudentCollection() : base() { }
		public StudentCollection(StudentCollection collection)
		{
			foreach(Student student in collection)
			{
				base.Add(student.Clone());
			}
			this.MaxOptions = collection.MaxOptions;
		}

		public void UnAssign()
		{
			foreach(Student s in list)
			{
				s.UnAssign();
			}
		}

	}
}
