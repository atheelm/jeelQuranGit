using Android.App;
using Android.Content;
using Android.Gms.Tasks;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Firestore;
using jeelQuranGit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeelQuranGit.Droid.FireStoreListener
{
    public class OnCompleteListener : Java.Lang.Object, IOnCompleteListener
    {
        private TaskCompletionSource<GradeStudents> _tcs;
        public OnCompleteListener(TaskCompletionSource<GradeStudents> tcs)
        {
            _tcs = tcs;
        }
        public Student GetStudentFromDocument(DocumentSnapshot studDoc)
        {
            Student newStudent = new Student("as", "Atheel", "None");
            String phone = studDoc.GetString("phone");

            return newStudent;
        }
        public void OnComplete(Android.Gms.Tasks.Task task)
        {
            if (task.IsSuccessful)
            {
                //process
                var result = task.Result;
                if (result is QuerySnapshot/*Query*/ col)
                {
                    IEnumerable<DocumentSnapshot> docs = col.Documents;
                    foreach (DocumentSnapshot doc in docs)
                    {
                        string phone = doc.GetString("phone");
                        string grade = doc.GetString("grade");
                        string name = doc.Id;
                        Student newStudent = new Student(grade, name, phone);
                    }                  

                    //QuerySnapshot allStudentsSnapshot =  await col.Get().Result;
                    /*if (result.Documents[0] is DocumentSnapshot doc)
                    {
                        Student newStudent = new Student("as", "Atheel", "None");
                        GradeStudents grade = new GradeStudents(1);
                        grade.addStudent(newStudent);
                        _tcs.TrySetResult(grade);
                    }*/
                }
            } else
            {
                //error
                _tcs.TrySetResult(default(GradeStudents));
            }
        }
    }
}