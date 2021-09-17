using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase;
using Firebase.Firestore;
using jeelQuranGit.Droid.FireStoreListener;
using jeelQuranGit.Droid.Services;
using jeelQuranGit.Models;
using jeelQuranGit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(GradeAndroidFirestore))]
namespace jeelQuranGit.Droid.Services
{
    public class GradeAndroidFirestore : IGradeStudentsFirestore
    {
        /*public GradeAndroidFirestore()
        {
            FirebaseApp.InitializeApp();
        }*/
        public async Task<GradeStudents> GetAllStudents(int grade)
        {
            
            var tcs = new TaskCompletionSource<GradeStudents>();
            FirebaseFirestore.Instance.Collection("StudentsNames").Get().AddOnCompleteListener(new OnCompleteListener(tcs));
            return await tcs.Task;
        }
    }
}