using SQLite.Net.Interop;
using SQLite;

using Xamarin.Forms;

namespace CrudMVVM.Model{
    public interface IConfig {
        string DiretorioDB { get; }
        ISQLitePlatform Plataforma { get; }
    }
}
