using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;
using System.Configuration;

namespace QuestRoomCatalog.Controllers
{
    public class AzureController : Controller
    {
        public string UploadFile()
        {
            string blobStorage = ConfigurationManager.ConnectionStrings["BlobStorageConnectionString"].ConnectionString;
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(blobStorage);

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer blobContainer = blobClient.GetContainerReference("containerforbacpac");
            blobContainer.CreateIfNotExists();

            blobContainer.SetPermissions(new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });
            CloudBlockBlob blob = blobContainer.GetBlockBlobReference("Images.jpg");
            using (var file = System.IO.File.OpenRead(@"C:\Test\1.jpg"))
            {
                blob.UploadFromStream(file);
            }
            return "";
        }

        /*Try to use this method!!!*/
        //public string UploadFile(HttpPostedFileBase fileToUpload)
        //{
        //    string absoluteUri;
        //    if (fileToUpload == null || fileToUpload.ContentLength == 0)
        //        return null;
        //    try
        //    {
        //        string fileName = Path.GetFileName(fileToUpload.FileName);
        //        CloudBlockBlob blockBlob;
        //        blockBlob = blobContainer.GetBlockBlobReference(fileName);
        //        blockBlob.Properties.ContentType = fileToUpload.ContentType;
        //        blockBlob.UploadFromStream(fileToUpload.InputStream);

        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    return absoluteUri;
        //}


        // GET: Azure

        public ActionResult Index()
        {
            UploadFile();
            return View();
        }
    }
}