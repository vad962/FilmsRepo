using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Windows.Media;

namespace FilmsDepot.Models
{
    public class Film
    {
        #region Properties
        //Идентификатор
        public Guid Id { get; set; }
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
        private ImageSource _img;          
        public ImageSource Img
        {
            get
            {
                return _img;
            }
            set
            {
                if (_img != value)
                {
                    _img = value;
                    sWidth = (int)_img.Width;
                    sHeight = (int)_img.Height;
                    OnPropertyChanged(new PropertyChangedEventArgs("Img"));
                }
            }
        }
        //Ширина картинки
        public int ImgWidth { get; set; }
        //Высота картинки
        public int ImgHeight { get; set; }

        #endregion Properties



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