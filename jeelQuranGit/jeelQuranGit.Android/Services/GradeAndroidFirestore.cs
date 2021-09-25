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
        public Task<List<Student>> GetAllStudents()
        {
            
            var tcs = new TaskCompletionSource<List<Student>>();
            FirebaseFirestore.Instance.Collection("StudentsNames").Get().AddOnCompleteListener(new OnCompleteListener(tcs));
            //tcs.Task.Start();//??
            //tcs.Task.Wait();
            return  tcs.Task;
        }
        public Task<List<Tuple<string, bool>>> GetGradeStudentsAttendances(int grade)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SetStudentAttendance(int grade, string name)
        {
            throw new NotImplementedException();
        }
    }
}