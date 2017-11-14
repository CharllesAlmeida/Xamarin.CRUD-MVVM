using SQLite.Net.Interop;
using System;
using CrudMVVM.Model;


[assembly: Xamarin.Forms.Dependency(typeof(CrudMVVM.Droid.Config))]

namespace CrudMVVM.Droid
{
     class Config : IConfig {
            private string _diretorioDB;
            private SQLite.Net.Interop.ISQLitePlatform _plataforma;

            public string DiretorioDB        {
                get {
                    if (string.IsNullOrEmpty(_diretorioDB)) {
                        _diretorioDB = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                    }
                    return _diretorioDB;
                }
            }

            public ISQLitePlatform Plataforma {
                get {
                    if (_plataforma == null) {
                        _plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                    }
                    return _plataforma;
                }
            }
        }
    }