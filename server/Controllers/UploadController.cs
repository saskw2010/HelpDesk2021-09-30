using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;

namespace Net5Wasm
{

    [DisableRequestSizeLimit]
    public partial class UploadController : Controller
    {



        private readonly IWebHostEnvironment environment;

        public UploadController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        // Single file upload
        [HttpPost("upload/single")]
        public async Task<IActionResult> SingleAsync(IFormFile file)
        {
            try
            {
                // Put your code here
                await Uploadfile(file);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Multiple files upload
        [HttpPost("upload/multiple")]
        public async Task<IActionResult> MultipleAsync(IFormFile[] files)
        {
            try
            {
                // Put your code here
                foreach (var file in files)
                {
                   await Uploadfile(file);

                }

                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Multiple files upload with parameter
        [HttpPost("upload/{id}")]
        public IActionResult Post(IFormFile[] files, int id)
        {
            try
            {
                // Put your code here
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Image file upload (used by HtmlEditor components)
        [HttpPost("upload/image")]
        public IActionResult Image(IFormFile file)
        {
            try
            {
                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";

                using (var stream = new FileStream(Path.Combine(environment.WebRootPath, fileName), FileMode.Create))
                {
                    // Save the file
                    file.CopyTo(stream);

                    // Return the URL of the file
                    var url = Url.Content($"~/{fileName}");

                    return Ok(new { Url = url });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        public async Task Uploadfile(IFormFile file)
        {
            // Check if thefile is there   
            if (file != null && file.Length > 0)
            {


                // Get the file name   
                var fileName = file.FileName;

                // Get the extension   
                var extension = Path.GetExtension(fileName);

                // Validate the extension based on your business needs   

                // Generate a new file to avoid dublicates = (FileName withoutExtension - GUId.extension)  
                var newFileName = $"{Path.GetFileNameWithoutExtension(fileName)}-{Guid.NewGuid().ToString()}{extension}";

                // Create the full path of the file including the directory (For this demo we will save the file insidea folder called Data within wwwroot)  
                var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "upload");
                var fullPath = Path.Combine(directoryPath, newFileName);

                // Maek sure the directory is ther bycreating it if it's not exist  
                Directory.CreateDirectory(directoryPath);

                // Create a new file stream where you want to put your file and copy the content from the current file stream to the new one   
                using (var fileStream = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    // Copy the content to the new stream   
                    await file.CopyToAsync(fileStream);
                }

                // You are done return the new URL which is (yourapplication url/data/newfilename)  
                //return Ok($"https://localhost:44302/Data/{newFileName}");
            }
        }
    }
}
