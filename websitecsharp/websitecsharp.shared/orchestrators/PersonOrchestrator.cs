﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using websitecsharp.domain;
using websitecsharp.domain.entities;
using websitecsharp.shared.enums;
using websitecsharp.shared.Interface;
using websitecsharp.shared.viewmodels;


namespace websitecsharp.shared.orchestrators
{
    public class PersonOrchestrator : iPersonOrchestrator
    {
        public readonly scorecontext _scorecontext = new scorecontext();
        public ErrorOrchestrator _errorOrchestrator = new ErrorOrchestrator();

        public Task<List<UpdateUserViewModel>> GetPeople()
        {
            try
            {
                var people = _scorecontext.Person.Select(x => new UpdateUserViewModel
                {
                    FirstName = x.firstName,
                    LastName = x.lastName,
                    Email = x.email,
                    PhoneNumber = x.phoneNumber,
                    PersonGender = (Gender)x.personGender,
                    DateCreated = x.dateCreated

                }).ToListAsync();

                return people;
            }
            catch(Exception e)
            {
                Task.Run(async () =>
                {
                    await _errorOrchestrator.RecordErrorAsync(e);

                });
                
                return null;
            }
        }


        public async Task<int> CreatePerson(UpdateUserViewModel person)
        {
            try
            {
                _scorecontext.Person.Add(new domain.entities.person
                {
                    firstName = person.FirstName,
                    lastName = person.LastName,
                    email = person.Email,
                    phoneNumber = person.PhoneNumber,
                    // personGender =  person.PersonGender,
                    dateCreated = person.DateCreated,
                    personID = person.personID

                });

                return await _scorecontext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                              
               await _errorOrchestrator.RecordErrorAsync(e);

                                
                return 0;
            }
        }


        public async Task<bool> UpdatePerson(UpdateUserViewModel person)
        {
            try
            {
                var updateEntity = await _scorecontext.Person.FindAsync(person.personID);

                if (updateEntity == null)
                {
                    return false;
                }

                updateEntity.firstName = person.FirstName;
                updateEntity.lastName = person.LastName;
                updateEntity.email = person.Email;
                updateEntity.dateCreated = person.DateCreated;
                updateEntity.phoneNumber = person.PhoneNumber;


                await _scorecontext.SaveChangesAsync();

                return true;
            }
            catch (Exception e)
            {
                               
              await _errorOrchestrator.RecordErrorAsync(e);

                return true;  
            }
        }

        public async Task<UpdateUserViewModel> SearchStudent(string searchString)
        {
            try
            {

                var student = await _scorecontext.Person
                    .Where(x => x.firstName.StartsWith(searchString))
                    .FirstOrDefaultAsync();

                if (student == null)
                {
                    return new UpdateUserViewModel();
                }

                var viewmodel = new UpdateUserViewModel
                {
                    FirstName = student.firstName,
                    LastName = student.lastName,
                    Email = student.email,
                    PhoneNumber = student.phoneNumber,
                    DateCreated = student.dateCreated,

                };

                return viewmodel;
            }
            catch (Exception e)
            {
                
                
                    await _errorOrchestrator.RecordErrorAsync(e);

                return new UpdateUserViewModel();
            }
        }
    }
}
