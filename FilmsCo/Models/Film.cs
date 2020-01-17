using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Windows.Media;
using System.Data.Entity;

namespace FilmsCo.Models
{
    public class Film
    {
        #region Properties

        //Первичный ключ
        public int Id { get; set; }
        //Название фильма
        public string Name { get; set; }
        //Описание фильма
        public string Description { get; set; }
        //Год выпуска фильма
        public string Year { get; set; }
        //Режиссер
        public string Producer { get; set; }
        //Владелец записи
        public string Owner { get; set; }
        //Изображение - постер
        public byte[] Poster { get; set; }
        //Картинка
        public HttpPostedFileBase File { get; set; }

        #endregion Properties

        #region Constructor

        public Film()
        {
            //guid = Guid.NewGuid();
        }

        #endregion Constructor

        #region Events

        //--------------------------------------------------
        //Реализация события PropertyChanged
        //--------------------------------------------------
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        #endregion Events


    }
}