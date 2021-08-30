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
        public void OnComplete(Android.Gms.Tasks.Task task)
        {
            if (task.IsSuccessful)
            {
                //process
                var result = task.Result;
                if (result is DocumentSnapshot doc)
                {
                    
                }
            } else
            {
                //error
            }
        }
    }
}