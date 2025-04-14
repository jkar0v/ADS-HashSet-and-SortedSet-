using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4__zad_za_ocenka_
{
    internal class RequestManager
    {
        HashSet<string> fileRequests = new HashSet<string>();
        Queue<FileRequest> fileRequestQueue = new Queue<FileRequest>();
        internal void AddRequest(FileRequest fileRequest)
        {
            if (!fileRequests.Contains(fileRequest.Name))
            {
                fileRequests.Add(fileRequest.Name);
                fileRequestQueue.Enqueue(fileRequest);
            }
        }
        internal void PrintRequests()
        {
            foreach (var request in fileRequestQueue)
            {
                Console.WriteLine($"Обработка на файл: {request.Name}");
            }
        }
    }
}
