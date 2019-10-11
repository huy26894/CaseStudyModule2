using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QLCafe.WEB.Models.TableCoffees;

namespace QLCafe.WEB.Controllers
{
    public class TableCoffeesController : Controller
    {

        public IActionResult Index()
        {
            var tableCoffees = new List<TableCoffeesView>();
            var url = "https://localhost:44354/api/TableCoffees/getall";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                tableCoffees = JsonConvert.DeserializeObject<List<TableCoffeesView>>(responseData);
            }
            return View(tableCoffees);
        }

        public IActionResult Create()
        {
            TempData["Success"] = null;
            return View();
        }

        [HttpPost]
        public IActionResult Create(TableCoffeesCreate model)
        {
            var createResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/TableCoffees/add");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                createResult = bool.Parse(result);
            }
            if (createResult)
            {
                TempData["Message"] = model.Name + " created successfully";
            }
            ModelState.Clear();
            //ViewBag.AreaID = GetAreaID();
            return View(new TableCoffeesCreate() { });
        }
        /*private List<AreaIDModel> GetAreaID()
        {
            var response = roomService.GetRooms();
            var data = response.Select(s => new RoomView()
            {
                Name = s.RoomName,
                Value = s.ID
            }).ToList();
            return data;
        }*/

        // làm thêm cái viewbag cho AreaId
        // tạo 1 cái AreaIdModel trong Models

        public IActionResult Delete(int id)
        {
            var model = new TableCoffeesDelete()
            {
                ID = id
            };
            var deleteResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/TableCoffees/delete/" + id);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "DELETE";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                deleteResult = bool.Parse(result);
            }
            return RedirectToAction("Index", "TableCoffees");
        }

        public IActionResult Details(int id)
        {
            var tableCoffees = new TableCoffeesView();
            var url = "https://localhost:44354/api/TableCoffees/get/" + id;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                tableCoffees = JsonConvert.DeserializeObject<TableCoffeesView>(responseData);
            }
            return View(tableCoffees);
        }

        public IActionResult Edit(int id)
        {
            var tableCoffeesEdit = new TableCoffeesEdit();
            var url = "https://localhost:44354/api/TableCoffees/get/" + id;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                tableCoffeesEdit = JsonConvert.DeserializeObject<TableCoffeesEdit>(responseData);
            }

            return View(tableCoffeesEdit);
        }

        [HttpPost]
        public IActionResult Edit(TableCoffeesEdit model)
        {
            var updateResult = false;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44354/api/TableCoffees/update");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                updateResult = bool.Parse(result);
            }
            if (updateResult)
            {
                TempData["Message"] = "User has been update successfully";
            }
            return View(new TableCoffeesEdit() { });
        }

        public IActionResult GetEmptyTable()
        {
            var getEmptyTable = new List<TableCoffeesGetEmptyTable>();
            var url = "https://localhost:44354/api/TableCoffees/getemptytable";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                getEmptyTable = JsonConvert.DeserializeObject<List<TableCoffeesGetEmptyTable>>(responseData);
            }
            return View(getEmptyTable);
        }

        public IActionResult GetNotEmptyTable()
        {
            var getNotEmptyTable = new List<TableCoffeesGetNotEmptyTable>();
            var url = "https://localhost:44354/api/TableCoffees/getnotemtytable";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                getNotEmptyTable = JsonConvert.DeserializeObject<List<TableCoffeesGetNotEmptyTable>>(responseData);
            }
            return View(getNotEmptyTable);
        }
    }
}