using BionetTX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BionetTX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

 
        #region ���媩-����
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region ���媩-�̷s����
        public IActionResult News()
        {
            return View();
        }
        #endregion

        #region ���媩-�T�p�ӭM����²��
        public IActionResult TxIntro()
        {
            return View();
        }
        #endregion

        #region ���媩-����²��
        public IActionResult CorpIntro()
        {
            return View();
        }
        #endregion

        #region ���媩-�ӭM�s��
        public IActionResult CellTherapy()
        {
            return View();
        }
        #endregion

        #region ���媩-�~�c��Exosome
        public IActionResult Exosome()
        {
            return View();
        }
        #endregion

        #region ���媩-�p���ڭ�
        public IActionResult Contact()
        {
            return View();
        }
        #endregion        
        
        #region ���媩-�Ӹ�ŧi
        public IActionResult Disclaimer()
        {
            return View();
        }
        #endregion

        #region ���媩-�s�D����-15
        public IActionResult NewsList15()
        {
            return View();
        }
        #endregion        
        
        #region ���媩-�s�D����-1
        public IActionResult NewsList1()
        {
            return View();
        }
        #endregion

        #region ���媩-�s�D����-2
        public IActionResult NewsList2()
        {
            return View();
        }
        #endregion

        #region ���媩-�s�D����-3
        public IActionResult NewsList3()
        {
            return View();
        }
        #endregion

        #region ���媩-�s�D����-4
        public IActionResult NewsList4()
        {
            return View();
        }
        #endregion

        #region ���媩-�s�D����-5
        public IActionResult NewsList5()
        {
            return View();
        }
        #endregion

        #region ���媩-�s�D����-6
        public IActionResult NewsList6()
        {
            return View();
        }
        #endregion

        #region ���媩-�s�D����-7
        public IActionResult NewsList7()
        {
            return View();
        }
        #endregion



       



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
