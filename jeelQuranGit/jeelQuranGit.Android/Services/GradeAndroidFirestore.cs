using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Firestore;
using jeelQuranGit.Droid.FireStoreListener;
using jeelQuranGit.Models;
using jeelQuranGit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeelQuranGit.Droid.Services
{
    public class GradeAndroidFirestore : GradeStudentsFirestore
    {
        public Task<GradeStudents> GetGradeStudents(int grade)
        {
            var tcs = new TaskCompletionSource<GradeStudents>();
            FirebaseFirestore.Instance.Collection("StudentsNames").Get().AddOnCompleteListener(new OnCompleteListener(tcs));
            return tcs.Task;
        }
    }
}