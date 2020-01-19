using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Windows.Media;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace FilmsCo.Models
{
    public enum FileType
    {
        Avatar = 1, Photo
    }

    public class Film
    {
        #region Properties

        //Первичный ключ
        public int Id { get; set; }
        //Название фильма
        [Required]
        [StringLength(255)]
        [Display(Name = "Название фильма")]
        public string Name { get; set; }
        //Описание фильма
        [Required]
        [StringLength(255)]
        [Display(Name = "Описание")]
        public string Description { get; set; }
        //Год выпуска фильма
        [Required]
        [StringLength(10)]
        [Display(Name = "Год выпуска")]
        public string Year { get; set; }
        //Режиссер
        [Required]
        [StringLength(255)]
        [Display(Name = "Режиссер")]
        public string Producer { get; set; }
        //Жанр
        [Required]
        [StringLength(255)]
        [Display(Name = "Жанр")]
        public string Genre { get; set; }
        //Владелец записи
        [Required]
        [StringLength(255)]
        [Display(Name = "Добавил")]
        public string Owner { get; set; }
        //------------------------------------------------
        //Коллекция картинок - постер
        //public virtual ICollection<ImgFile> ImgFiles { get; set; }
        //Картинка - постер
        public byte[] Poster { get; set; }
        //Картинка
        public HttpPostedFileBase File { get; set; }
        //Название картинки
        [StringLength(255)]
        public string PosterName { get; set; }
        //Тип картинки
        [StringLength(100)]
        public string ContentType { get; set; }
        ////Длина массива байт картинки
        //public int ContentLength { get; set; }
        //-------------------------------------------------
        #endregion Properties

        #region Constructor

        public Film()
        {
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

    //public class ImgFile
    //{
    //    [Key]
    //    public int FileId { get; set; }
    //    [StringLength(255)]
    //    public string FileName { get; set; }
    //    [StringLength(100)]
    //    public string ContentType { get; set; }
    //    public byte[] Content { get; set; }
    //    public FileType FileType { get; set; }
    //    public int FilmId { get; set; }
    //    public virtual Film Film { get; set; }
    //}
}