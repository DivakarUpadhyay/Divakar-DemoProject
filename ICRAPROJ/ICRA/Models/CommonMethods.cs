using Amazon.S3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ICRA.Models
{
	public class CommonMethods
	{

        public async Task<Stream> ReadObjectData1(String fileName)
        {
            try
            {
                string accessKey = "AKIA6H7L4Y6MBR4SCJJ3";
                string accessSecret = "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";
                String key = "Images";
                string myBucketName = "icrabcweb";
                using (var client = new AmazonS3Client(accessKey, accessSecret, Amazon.RegionEndpoint.APSouth1))
                {
                    var request = new Amazon.S3.Model.GetObjectRequest
                    {
                        BucketName = myBucketName,
                        Key = key + "/" + fileName
                    };

                    using (var getObjectResponse = await client.GetObjectAsync(request))
                    {
                        using (var responseStream = getObjectResponse.ResponseStream)
                        {
                            var stream = new MemoryStream();
                            await responseStream.CopyToAsync(stream);
                            stream.Position = 0;
                            Image image = System.Drawing.Image.FromStream(stream);
                            string ImageUrl = "data:image/png;base64," + Convert.ToBase64String(stream.ToArray(), 0, stream.ToArray().Length);
                          //  ImageData = ImageUrl;
                            // image.Save(@"C:\\ICRA\\ICRA\\ICRA\\Images" + "\\Image1.jpg", ImageFormat.Jpeg);
                            return stream;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Read object operation failed.", exception);
            }
        }

        public  string ReadObjectData(String fileName)
        {
            string accessKey = "AKIA6H7L4Y6MBR4SCJJ3";
            string accessSecret = "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";
            String key = "Images";
            string myBucketName = "icrabcweb";

            try
            {
                using (var client = new AmazonS3Client(accessKey, accessSecret, Amazon.RegionEndpoint.APSouth1))
                {
                    var request = new Amazon.S3.Model.GetObjectRequest
                    {
                        BucketName = myBucketName,
                        Key = key + "/" + fileName
                        
                    };

                    using (var getObjectResponse = client.GetObject(request))
                    {
                        using (var responseStream = getObjectResponse.ResponseStream)
                        {
                            var stream = new MemoryStream();
                            responseStream.CopyToAsync(stream);
                            stream.Position = 0;
                            //Image image = System.Drawing.Image.FromStream(stream);
                            string base64Image = Convert.ToBase64String(stream.ToArray(), 0, stream.ToArray().Length);
                            string ImageUrl = "data:image/png;base64," + base64Image;

                            return ImageUrl;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Read object operation failed.", exception);
            }

        }
        public string ReadImage(String fileName)
        {
             try
            {
                string Link = System.Configuration.ConfigurationManager.AppSettings["S3Link"];
                string Image = Link + fileName;
                return Image;
            }
            catch (Exception exception)
            {
                throw new Exception("Read object operation failed.", exception);
            }

        }

        enum ContactusEmailCategory
        {
           Contact_Us_Get_Callback,
           Contact_Us_Ask_Our_Industry_Expert,
           Contact_Us_Ask_Our_BD
        }
    }
}