﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Trabalho.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IServiceProvider appServices)
        {
            TrabalhoDbContext context = (TrabalhoDbContext)appServices.GetService(typeof(TrabalhoDbContext));


            if (!context.Turist.Any())
            {
                EnsureTuristPopulated(context);
            }

            context.SaveChanges();


            if (!context.Questions.Any())
            {
                EnsureQuestionsPopulated(context);
            }

            context.SaveChanges();


            if (!context.Difficulty.Any())
            {
                EnsureDifficultyPopulated(context);
            }

            context.SaveChanges();


            if (!context.TypeAnswer.Any())
            {
                EnsureTypeAnswerPopulated(context);
            }

            context.SaveChanges();


            if (!context.Trails.Any())
            {
                EnsureTrailsPopulated(context);
            }

            context.SaveChanges();


            if (!context.Parameters.Any())
            {
                EnsureParametersPopulated(context);
            }

            context.SaveChanges();


            if (!context.TuristAnswer.Any())
            {
                EnsureTuristAnswerPopulated(context);
            }

            context.SaveChanges();

        }
            

            private static void EnsureTuristPopulated(TrabalhoDbContext dbContext)
            {
                dbContext.Turist.AddRange(
                    new Turist
                    {
                        TuristName = " João",
                        Phone = 963123456,
                        Genre = true,
                        Birthday = DateTime.Parse("01-09-1996"),
                        NIF = 313212454,
                        Email = "joao@gmail.com",
                        EmergencyContact = 963123456,
                        TuristState = true
                    },

                   new Turist
                   {
                       TuristName = "Luis",
                       Phone = 963124356,
                       Genre = true,
                       Birthday = DateTime.Parse("01-09-1991"),
                       NIF = 313212431,
                       Email = "luis@gmail.com",
                       EmergencyContact = 963124356,
                       TuristState = true
                   },

                     new Turist
                     {
                         TuristName = "André",
                         Phone = 963112156,
                         Genre = true,
                         Birthday = DateTime.Parse("01-09-1995"),
                         NIF = 313666431,
                         Email = "andre@gmail.com",
                         EmergencyContact = 963112156,
                         TuristState = false
                     }
                );

            }

            private static void EnsureQuestionsPopulated(TrabalhoDbContext dbContext)
            {
                dbContext.Questions.AddRange(
                new Questions { QuestionsToClient = "Qual é a sua altura?", QuestionsState = true },
                new Questions { QuestionsToClient = "Qual é a sua idade?", QuestionsState = true },
                new Questions { QuestionsToClient = "Qual é o seu peso?", QuestionsState = false },
                new Questions { QuestionsToClient = "Tem algumas destas doenças?", QuestionsState = true }

                );

            }


        private static void EnsureDifficultyPopulated(TrabalhoDbContext dbContext)
        {
            dbContext.Difficulty.AddRange(
           new Difficulty { DifficultyName = "Fácil" },
           new Difficulty { DifficultyName = "Médio" },
           new Difficulty { DifficultyName = "Dificil" }

            );

        }

        private static void EnsureTypeAnswerPopulated(TrabalhoDbContext dbContext)
        {
            dbContext.TypeAnswer.AddRange(

                new TypeAnswer { PossibleAnswer = "150 - 169", QuestionsID = 1 },
                new TypeAnswer { PossibleAnswer = "170 - 179", QuestionsID = 1 },
                new TypeAnswer { PossibleAnswer = ">180", QuestionsID = 1 },

                new TypeAnswer { PossibleAnswer = "7 - 17", QuestionsID = 2 },
                new TypeAnswer { PossibleAnswer = "18 - 54", QuestionsID = 2 },
                new TypeAnswer { PossibleAnswer = ">55", QuestionsID = 2 },

                new TypeAnswer { PossibleAnswer = "50 - 79", QuestionsID = 3 },
                new TypeAnswer { PossibleAnswer = "80 - 99", QuestionsID = 3 },
                new TypeAnswer { PossibleAnswer = ">100", QuestionsID = 3 },

                new TypeAnswer { PossibleAnswer = "Não", QuestionsID = 4 },
                new TypeAnswer { PossibleAnswer = "Problemas Cardiológicos", QuestionsID = 4 },
                new TypeAnswer { PossibleAnswer = "Osteoporose", QuestionsID = 4 }
            );

        }

        private static void EnsureTrailsPopulated(TrabalhoDbContext dbContext)
        {
            dbContext.Trails.AddRange(
           new Trails
           {
               Description = "Um Percurso ao ar livre, pouco inclinado",
               DifficultyID = 1,
               Distance = 9,
               InitialDate = DateTime.Parse("26-08-2011"),
               TrailsName = "Percurso ao Ar Livre",
               TrailsState = true,
               FinalDate = DateTime.Parse("01-05-2012"),
               TrailsStateDate = DateTime.Parse("25-08-2011")
           },

             new Trails
             {
                 Description = "Um Percurso longo, alguma inclinação",
                 DifficultyID = 2,
                 Distance = 18,
                 InitialDate = DateTime.Parse("26-04-2012"),
                 TrailsName = "Percurso Longo ao Ar Livre",
                 TrailsState = true,
                 FinalDate = DateTime.Parse("15-01-2013"),
                 TrailsStateDate = DateTime.Parse("27-04-2012")
             },

             new Trails
             {
                 Description = "Um Percurso longo, com passagens subterrâneas e cavernas",
                 DifficultyID = 3,
                 Distance = 21,
                 InitialDate = DateTime.Parse("11-06-2013"),
                 TrailsName = "Percurso Subterrâneo",
                 TrailsState = true,
                 FinalDate = DateTime.Parse("10-06-2014"),
                 TrailsStateDate = DateTime.Parse("12-06-2013")
             }
            );

        }

        private static void EnsureParametersPopulated(TrabalhoDbContext dbContext)
        {
            dbContext.Parameters.AddRange(
             new Parameters{ QuestionsID = 1,
               DifficultyID = 1,
               AllowedAnswer = 1},

             new Parameters{ QuestionsID = 1,
               DifficultyID = 2,
               AllowedAnswer = 2},

               new Parameters{ QuestionsID = 1,
               DifficultyID = 3,
               AllowedAnswer = 3},



               new Parameters{ QuestionsID = 2,
               DifficultyID = 1,
               AllowedAnswer = 4},

               new Parameters{ QuestionsID = 2,
               DifficultyID = 2,
               AllowedAnswer = 5},

               new Parameters{ QuestionsID = 2,
               DifficultyID = 3,
               AllowedAnswer = 6},



               new Parameters{ QuestionsID = 3,
               DifficultyID = 1,
               AllowedAnswer = 7},

               new Parameters{ QuestionsID = 3,
               DifficultyID = 2,
               AllowedAnswer = 8},

               new Parameters{ QuestionsID = 3,
               DifficultyID = 3,
               AllowedAnswer = 9},



               new Parameters{ QuestionsID = 4,
               DifficultyID = 1,
               AllowedAnswer = 10},

               new Parameters{ QuestionsID = 4,
               DifficultyID = 2,
               AllowedAnswer = 11},

               new Parameters{ QuestionsID = 4,
               DifficultyID = 3,
               AllowedAnswer = 12}

            );

        }

        private static void EnsureTuristAnswerPopulated(TrabalhoDbContext dbContext)
        {
            dbContext.TuristAnswer.AddRange(

                  new TuristAnswer
                  {
                      TuristID = 1,
                      QuestionsID = 1,
                      SurveyNumber = 1,
                      TuristAnswerName = 2,
                      AnswerDate = DateTime.Parse("15-03-2013")
                  },


          new TuristAnswer
          {
              TuristID = 1,
              QuestionsID = 2,
              SurveyNumber = 1,
              TuristAnswerName = 5,
              AnswerDate = DateTime.Parse("15-03-2013")
          },


          new TuristAnswer
          {
              TuristID = 1,
              QuestionsID = 3,
              SurveyNumber = 1,
              TuristAnswerName = 7,
              AnswerDate = DateTime.Parse("15-03-2013")
          },


          new TuristAnswer
          {
              TuristID = 1,
              QuestionsID = 4,
              SurveyNumber = 1,
              TuristAnswerName = 10,
              AnswerDate = DateTime.Parse("15-03-2013")
          }

            );

        }










        
    }
}
