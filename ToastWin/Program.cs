using System;
using System.Runtime.InteropServices;

namespace ToastWin
{
    class Program
    {
        // NOTIFYICONDATA yapısını tanımlıyoruz
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct NOTIFYICONDATA
        {
            public uint cbSize;
            public IntPtr hWnd;
            public uint uID;
            public uint uFlags;
            public uint uCallbackMessage;
            public IntPtr hIcon;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szTip;
            public uint dwState;
            public uint dwStateMask;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string szInfo;
            public uint uTimeoutOrVersion;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string szInfoTitle;
            public uint dwInfoFlags;
            public Guid guidItem;
            public IntPtr hBalloonIcon;
        }

        // API fonksiyonları
        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        static extern bool Shell_NotifyIcon(uint dwMessage, ref NOTIFYICONDATA lpData);

        const uint NIM_ADD = 0x00000000;
        const uint NIM_MODIFY = 0x00000001;
        const uint NIM_DELETE = 0x00000002;

        const uint NIF_MESSAGE = 0x00000001;
        const uint NIF_ICON = 0x00000002;
        const uint NIF_TIP = 0x00000004;
        const uint NIF_INFO = 0x00000010;

        const uint NIIF_NONE = 0x00000000;
        const uint NIIF_INFO = 0x00000001;
        const uint NIIF_WARNING = 0x00000002;
        const uint NIIF_ERROR = 0x00000003;
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
        static void Main(string[] args)
        {
            // Önce önceki bildirim varsa sil
            //DeletePreviousNotification();

            //// Yeni bildirim gönder
            //ShowNotification("Bildirim Başlığı", "Bu bir hatırlatıcı bildirim.");
            MessageBox(IntPtr.Zero, "Merhaba Dünya", "Başlık", 0);
            Console.ReadLine(); // Programın bitmesini engellemek için
        }

        static void ShowNotification(string title, string text)
        {
            NOTIFYICONDATA notifyIconData = new NOTIFYICONDATA();

            // cbSize, yapının boyutunu ayarlıyoruz (çok önemli)
            notifyIconData.cbSize = (uint)Marshal.SizeOf(notifyIconData);

            // Pencere tanıtıcısını ve benzersiz ID'yi ayarlayın
            notifyIconData.hWnd = IntPtr.Zero; // Konsol uygulaması için null bırakılabilir
            notifyIconData.uID = 1; // Benzersiz ID

            // Bildirim başlığı ve içeriğini ayarlıyoruz
            notifyIconData.szInfo = text;
            notifyIconData.szInfoTitle = title;

            // Bildirim türünü ayarlıyoruz
            notifyIconData.dwInfoFlags = NIIF_INFO;
            notifyIconData.uFlags = NIF_INFO | NIF_TIP;

            // İkon atanmazsa, bazı sistemlerde bildirim görünmeyebilir
            notifyIconData.hIcon = IntPtr.Zero; // İsterseniz bir ikon ekleyebilirsiniz

            // Bildirimi gönderiyoruz
            Shell_NotifyIcon(NIM_ADD, ref notifyIconData);
        }

        static void DeletePreviousNotification()
        {
            NOTIFYICONDATA notifyIconData = new NOTIFYICONDATA();
            notifyIconData.cbSize = (uint)Marshal.SizeOf(notifyIconData);
            notifyIconData.hWnd = IntPtr.Zero;
            notifyIconData.uID = 1;

            // Önceki bildirimi sil
            Shell_NotifyIcon(NIM_DELETE, ref notifyIconData);
        }
    }
}
