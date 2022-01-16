using System;

namespace InterfaceSegregation
{
    interface IPhone
    {
        void Call();
        void TakePhoto();
        void MakeVideo();
        void BrowseInternet();
    }

    class Phone : IPhone
    {
        public void Call()
        {
            Console.WriteLine("Звоним");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем");
        }

        public void MakeVideo()
        {
            Console.WriteLine("Снимаем видео");
        }

        public void BrowseInternet()
        {
            Console.WriteLine("Серфим в интернете");
        }
    }

    class Photograph
    {
        public void TakePhoto(Phone phone)
        {
            phone.TakePhoto();
        }
    }

    class Camera : IPhone
    {
        public void Call() { }
        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем");
        }
        public void MakeVideo() { }
        public void BrowseInternet() { }
    }



    interface ICall
    {
        void Call();
    }

    interface IPhoto
    {
        void TakePhoto();
    }

    interface IVideo
    {
        void MakeVideo();
    }

    interface IWeb
    {
        void BrowseInternet();
    }

    class CameraSegregation : IPhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем с помощью фотокамеры");
        }
    }

    class PhoneSegregation : ICall, IPhoto, IVideo, IWeb
    {
        public void Call()
        {
            Console.WriteLine("Звоним");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем с помощью смартфона");
        }

        public void MakeVideo()
        {
            Console.WriteLine("Снимаем видео");
        }

        public void BrowseInternet()
        {
            Console.WriteLine("Серфим в интернете");
        }
    }

    class PhotographSegregation
    {
        public void TakePhoto(IPhoto photoMaker)
        {
            photoMaker.TakePhoto();
        }
    }
}
