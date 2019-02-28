using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using websitecsharp.domain;
using websitecsharp.shared.Interface;
using websitecsharp.shared.viewmodels;

namespace websitecsharp.shared.orchestrators
{
    public class ErrorOrchestrator : iErrorOrchestrator
    {
        public scorecontext _scorecontext = new scorecontext();

        public async Task<int> AddErrorRecord(ErrorViewModel ErrorToAdd)
        {
            _scorecontext.ErrorDatabase.Add(new domain.entities.Error
            {
                
                Id = ErrorToAdd.ErrorId,
                ErrorDateTime = ErrorToAdd.ErrorTime,
                StackTrack = ErrorToAdd.StackTrace,
                InnerExceptions = ErrorToAdd.InnerException,
                ErrorMessage = ErrorToAdd.ErrorMessage

            });

            return await _scorecontext.SaveChangesAsync();

        }

        public async Task GenerateError()
        {
            try
            {
                
                throw new System.OutOfMemoryException();

            } catch(Exception e)
            {
                var error = new ErrorViewModel();

                error.ErrorId = Guid.NewGuid();
                error.ErrorTime = DateTime.Now;
                error.StackTrace = e.StackTrace;
                error.ErrorMessage = e.Message;
                if (e.InnerException == null)
                {
                    error.InnerException = "None";
                }else
                {
                    error.InnerException = e.InnerException.ToString();
                }
                            

               var x = await AddErrorRecord(error);
            }
        }

        public async Task RecordErrorAsync(Exception ex)
        {
            var error = new ErrorViewModel();

            error.ErrorId = Guid.NewGuid();
            error.ErrorTime = DateTime.Now;
            error.StackTrace = ex.StackTrace;
            error.ErrorMessage = ex.Message;
            if (ex.InnerException == null)
            {
                error.InnerException = "None";
            }
            else
            {
                error.InnerException = ex.InnerException.ToString();
            }


            var x = await AddErrorRecord(error);

            
        }

        
    }
}
