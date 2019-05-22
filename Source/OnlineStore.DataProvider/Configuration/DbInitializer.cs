using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using OnlineStore.DataProvider.Context;
using OnlineStore.DataProvider.Entities;
using OnlineStore.DataProvider.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Configuration
{
    internal class DbInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        private enum RoleTypes
        {
            Administrator,
            Manager,
            Owner,
            Customer
        }
        protected override void Seed(ApplicationDbContext context)
        {
            #region SqlCommands

            context.Database.ExecuteSqlCommand("ALTER TABLE [dbo].[Categories] DROP CONSTRAINT [FK_dbo.Categories_dbo.Stocks_StockId]");
            context.Database.ExecuteSqlCommand("ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Categories_dbo.Stocks_StockId] FOREIGN KEY([StockId]) REFERENCES[dbo].[Stocks]([StockId]) ON DELETE SET NULL");
            context.Database.ExecuteSqlCommand("ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_dbo.Categories_dbo.Stocks_StockId]");

            context.Database.ExecuteSqlCommand("ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_dbo.Products_dbo.Stocks_StockId]");
            context.Database.ExecuteSqlCommand("ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Products_dbo.Stocks_StockId] FOREIGN KEY([StockId]) REFERENCES[dbo].[Stocks]([StockId]) ON DELETE SET NULL");
            context.Database.ExecuteSqlCommand("ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_dbo.Products_dbo.Stocks_StockId]");

            #endregion

            #region Languages

            Language russion = new Language()
            {
                LanguageCode = "ru",
                LanguageName = "Русский",
                ImageFilename = "ru.svg"
            };
            Language english = new Language()
            {
                LanguageCode = "en",
                LanguageName = "English",
                ImageFilename = "en.svg"
            };

            context.Languages.AddRange(new List<Language>() { russion, english });

            #endregion

            #region Albums

            Album dmAlbum = new Album()
            {
                AlbumTranslates = new List<AlbumTranslate>()
                {
                    new AlbumTranslate()
                    {
                        AlbumName = "Dionaea Muscipula",
                        Language = english,
                        PageDescription = "Gallery - Dionaea Muscipula album",
                        PageKeywords = "Dionaea Muscipula, Dionaea, Muscipula"
                    },
                    new AlbumTranslate()
                    {
                        AlbumName = "Венерина Мухоловка",
                        Language = russion,
                        PageDescription = "Галлерея - Альбом Венерина Мухоловка",
                        PageKeywords = "Венерина Мухоловка, Дионея, Мухоловка, Росянковые"
                    }
                },
                AlbumImageFilename = "dionaea-muscipula-album.jpg",
                ModifiedDate = DateTime.UtcNow,
                AlbumImages = new List<AlbumImage>()
                {
                    new AlbumImage()
                    {
                        ImageFilename = "dm-typical-in-wild.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Dionaea Muscipula \"Typical\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Венерина Мухоловка \"Типичная\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "dm-b52.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Dionaea Muscipula \"B52\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Венерина Мухоловка \"Б52\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "dm-b52-1.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Dionaea Muscipula \"B52\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Венерина Мухоловка \"Б52\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "dm-dente.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Dionaea Muscipula \"Dente\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Венерина Мухоловка \"Денте\"",
                                Language = russion
                            }
                        }
                    }
                },
                ImageCount = 4
            };
            Album drAlbum = new Album()
            {
                AlbumTranslates = new List<AlbumTranslate>()
                {
                    new AlbumTranslate()
                    {
                        AlbumName = "Drosera",
                        Language = english,
                        PageDescription = "Gallery - Drosera album",
                        PageKeywords = "Drosera"
                    },
                    new AlbumTranslate()
                    {
                        AlbumName = "Росянка",
                        Language = russion,
                        PageDescription = "Галлерея - Альбом Росянка",
                        PageKeywords = "Росянка, Росянковые"
                    }
                },
                AlbumImageFilename = "drosera-album.jpg",
                ModifiedDate = DateTime.UtcNow,
                AlbumImages = new List<AlbumImage>()
                {
                    new AlbumImage()
                    {
                        ImageFilename = "dr-rotundifolia.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Drosera \"Rotundifolia\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Росянка \"Круглолистная\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "dr-rotundifolia-1.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Drosera \"Rotundifolia\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Росянка \"Круглолистная\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "dr-nidiformis.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Drosera \"Nidiformis\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Росянка \"Нидиформис\"",
                                Language = russion
                            }
                        }
                    }
                },
                ImageCount = 3
            };
            Album npAlbum = new Album()
            {
                AlbumTranslates = new List<AlbumTranslate>()
                {
                    new AlbumTranslate()
                    {
                        AlbumName = "Nepenthes",
                        Language = english,
                        PageDescription = "Gallery - Nepenthes album",
                        PageKeywords = "Nepenthes"
                    },
                    new AlbumTranslate()
                    {
                        AlbumName = "Непентес",
                        Language = russion,
                        PageDescription = "Галлерея - Альбом Непентес",
                        PageKeywords = "Непентес"
                    }
                },
                AlbumImageFilename = "nepenthes-album.jpg",
                ModifiedDate = DateTime.UtcNow,
                AlbumImages = new List<AlbumImage>()
                {
                    new AlbumImage()
                    {
                        ImageFilename = "np-alata.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Nepenthes \"Alata\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Непентес \"Алата\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "np-alata-1.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Nepenthes \"Alata\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Непентес \"Алата\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "np-alata-2.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Nepenthes \"Alata\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Непентес \"Алата\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "np-alata-3.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Nepenthes \"Alata\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Непентес \"Алата\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "np-hookeriana.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Nepenthes \"Hookeriana\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Непентес \"Хукериана\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "np-sanguinea.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Nepenthes \"Sanguinea\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Непентес \"Сангвинея\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "np-ventrata.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Nepenthes \"Ventrata\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Непентес \"Вентрата\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "np-ventricosa.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Nepenthes \"Ventricosa\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Непентес \"Вентрикоса\"",
                                Language = russion
                            }
                        }
                    }
                }
            };
            Album srAlbum = new Album()
            {
                AlbumTranslates = new List<AlbumTranslate>()
                {
                    new AlbumTranslate()
                    {
                        AlbumName = "Sarracenia",
                        Language = english,
                        PageDescription = "Gallery - Sarracenia album",
                        PageKeywords = "Sarracenia"
                    },
                    new AlbumTranslate()
                    {
                        AlbumName = "Саррацения",
                        Language = russion,
                        PageDescription = "Галлерея - Альбом Саррацения",
                        PageKeywords = "Саррацения"
                    }
                },
                AlbumImageFilename = "sarracenia-album.jpg",
                ModifiedDate = DateTime.UtcNow,
                AlbumImages = new List<AlbumImage>()
                {
                    new AlbumImage()
                    {
                        ImageFilename = "sr-alata.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Sarracenia \"Alata\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Саррацения \"Алата\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "sr-leucophylla.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Sarracenia \"Leucophylla\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Саррацения \"Лейкофилла\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "sr-purpurea.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Sarracenia \"Purpurea\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Саррацения \"Пурпурная\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "sr-rubra.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Sarracenia \"Rubra\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Саррацения \"Красная (рубра)\"",
                                Language = russion
                            }
                        }
                    }
                }
            };
            Album pnAlbum = new Album()
            {
                AlbumTranslates = new List<AlbumTranslate>()
                {
                    new AlbumTranslate()
                    {
                        AlbumName = "Pinguicula",
                        Language = english,
                        PageDescription = "Gallery - Pinguicula album",
                        PageKeywords = "Pinguicula"
                    },
                    new AlbumTranslate()
                    {
                        AlbumName = "Жирянка",
                        Language = russion,
                        PageDescription = "Галлерея - Альбом Жирянка",
                        PageKeywords = "Жирянка"
                    }
                },
                AlbumImageFilename = "pinguicula-album.jpg",
                ModifiedDate = DateTime.UtcNow,
                AlbumImages = new List<AlbumImage>()
                {
                    new AlbumImage()
                    {
                        ImageFilename = "pn-ehlersiae.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Pinguicula \"Ehlersiae\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Жирянка \"Эхлерсия\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "pn-moranensis.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Pinguicula \"Moranensis\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Жирянка \"Мораненсис\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "pn-vulgaris.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Pinguicula \"Vulgaris\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Жирянка \"Вульгарис\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "pn-weser.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Pinguicula \"Weser\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Жирянка \"Весер\"",
                                Language = russion
                            }
                        }
                    }
                }
            };
            Album utAlbum = new Album()
            {
                AlbumTranslates = new List<AlbumTranslate>()
                {
                    new AlbumTranslate()
                    {
                        AlbumName = "Utricularia",
                        Language = english,
                        PageDescription = "Gallery - Utricularia album",
                        PageKeywords = "Utricularia"
                    },
                    new AlbumTranslate()
                    {
                        AlbumName = "Пузырчатка",
                        Language = russion,
                        PageDescription = "Галлерея - Альбом Пузырчатка",
                        PageKeywords = "Пузырчатка"
                    }
                },
                AlbumImageFilename = "utricularia-album.jpg",
                ModifiedDate = DateTime.UtcNow,
                AlbumImages = new List<AlbumImage>()
                {
                    new AlbumImage()
                    {
                        ImageFilename = "ut-girra.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Utricularia \"Girra\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Пузырчатка \"Джира\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "ut-girra-1.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Utricularia \"Girra\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Пузырчатка \"Джира\"",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "ut-vulgaris.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Utricularia \"Vulgaris\"",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Пузырчатка \"Вульгарис\"",
                                Language = russion
                            }
                        }
                    }
                }
            };
            Album dcAlbum = new Album()
            {
                AlbumTranslates = new List<AlbumTranslate>()
                {
                    new AlbumTranslate()
                    {
                        AlbumName = "Darlingtonia Californica",
                        Language = english,
                        PageDescription = "Gallery - Darlingtonia Californica album",
                        PageKeywords = "Darlingtonia Californica, Darlingtonia, Californica"
                    },
                    new AlbumTranslate()
                    {
                        AlbumName = "Дарлингтония Калифорнийская",
                        Language = russion,
                        PageDescription = "Галлерея - Альбом Дарлингтония Калифорнийская",
                        PageKeywords = "Дарлингтония Калифорнийская, Дарлингтония"
                    }
                },
                AlbumImageFilename = "darlingtonia-californica-album.jpg",
                ModifiedDate = DateTime.UtcNow,
                AlbumImages = new List<AlbumImage>()
                {
                    new AlbumImage()
                    {
                        ImageFilename = "dc.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Darlingtonia Californica",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Дарлингтония Калифорнийская",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "dc-1.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Darlingtonia Californica",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Дарлингтония Калифорнийская",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "dc-2.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Darlingtonia Californica",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Дарлингтония Калифорнийская",
                                Language = russion
                            }
                        }
                    }
                }
            };
            Album cfAlbum = new Album()
            {
                AlbumTranslates = new List<AlbumTranslate>()
                {
                    new AlbumTranslate()
                    {
                        AlbumName = "Cephalotus Follicularis",
                        Language = english,
                        PageDescription = "Gallery - Cephalotus Follicularis album",
                        PageKeywords = "Cephalotus Follicularis, Cephalotus, Follicularis"
                    },
                    new AlbumTranslate()
                    {
                        AlbumName = "Цефалотус Мешочковидный",
                        Language = russion,
                        PageDescription = "Галлерея - Альбом Цефалотус Мешочковидный",
                        PageKeywords = "Цефалотус Мешочковидный, Цефалотус, Мешочковидный"
                    }
                },
                AlbumImageFilename = "cephalotus-follicularis-album.jpg",
                ModifiedDate = DateTime.UtcNow,
                AlbumImages = new List<AlbumImage>()
                {
                    new AlbumImage()
                    {
                        ImageFilename = "cf.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Cephalotus Follicularis",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Цефалотус Мешочковидный",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "cf-1.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Cephalotus Follicularis",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Цефалотус Мешочковидный",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "cf-2.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Cephalotus Follicularis",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Цефалотус Мешочковидный",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "cf-3.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Cephalotus Follicularis",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Цефалотус Мешочковидный",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "cf-4.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Cephalotus Follicularis",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Цефалотус Мешочковидный",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "cf-5.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Cephalotus Follicularis",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Цефалотус Мешочковидный",
                                Language = russion
                            }
                        }
                    },
                    new AlbumImage()
                    {
                        ImageFilename = "cf-6.jpg",
                        AddedDate = DateTime.UtcNow,
                        AlbumImageTranslates = new List<AlbumImageTranslate>()
                        {
                            new AlbumImageTranslate()
                            {
                                Description = "Cephalotus Follicularis",
                                Language = english
                            },
                            new AlbumImageTranslate()
                            {
                                Description = "Цефалотус Мешочковидный",
                                Language = russion
                            }
                        }
                    }
                }
            };

            context.Albums.AddRange(new List<Album>() { dmAlbum, drAlbum, npAlbum, srAlbum, pnAlbum, utAlbum, dcAlbum, cfAlbum });

            #endregion

            #region Users and Roles

            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            var roleManager = new ApplicationUserRoleManager(new RoleStore<ApplicationUserRole>(context));

            List<ApplicationUserRole> roles = new List<ApplicationUserRole>()
            {
                new ApplicationUserRole(RoleTypes.Administrator.ToString()),
                new ApplicationUserRole(RoleTypes.Customer.ToString()),
                new ApplicationUserRole(RoleTypes.Manager.ToString()),
                new ApplicationUserRole(RoleTypes.Owner.ToString())
            };
            foreach(var role in roles)
            {
                if (!roleManager.RoleExists(role.Name))
                {
                    roleManager.Create(role);
                }
            }

            List<ApplicationUser> users = new List<ApplicationUser>()
            {
                new ApplicationUser()
                {
                    Email = "venusflytrapshop@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "+375259507009",
                    PhoneNumberConfirmed = true,
                    UserName = "Admin",
                    ApplicationUserProfile = new ApplicationUserProfile()
                    {
                        Name = "Alexey",
                        Surname = "Kosyuk",
                        Patronymic = "Andreevich",
                        ImageFilename = "admin-logo.jpg"
                    },
                    Administrator = new Administrator(),
                    Language = russion
                },
                new ApplicationUser()
                {
                    Email = "venusflytrapshop@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "+375259507009",
                    PhoneNumberConfirmed = true,
                    UserName = "Owner",
                    ApplicationUserProfile = new ApplicationUserProfile()
                    {
                        Name = "Alexey",
                        Surname = "Kosyuk",
                        Patronymic = "Andreevich",
                        ImageFilename = "owner-logo.jpg"
                    },
                    Owner = new Owner(),
                    Language = russion
                },
                new ApplicationUser()
                {
                    Email = "venusflytrapshop@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "+375259507009",
                    PhoneNumberConfirmed = true,
                    UserName = "Manager",
                    ApplicationUserProfile = new ApplicationUserProfile()
                    {
                        Name = "Alexey",
                        Surname = "Kosyuk",
                        Patronymic = "Andreevich",
                        ImageFilename = "manager-logo.jpg"
                    },
                    Manager = new Manager(),
                    Language = russion
                }
            };
            foreach(var u in users)
            {
                var user = userManager.FindById(u.Id);
                if(user is null)
                {
                    switch (u.UserName)
                    {
                        case "Admin":
                            {
                                userManager.Create(u, "dk.U72a,9qWnI0eR.pL4,bg3");
                                userManager.AddToRole(u.Id, RoleTypes.Administrator.ToString());
                                break;
                            }
                        case "Manager":
                            {
                                userManager.Create(u, "9qWn.U72a,dk,bg3I0eR.pZ4");
                                userManager.AddToRole(u.Id, RoleTypes.Manager.ToString());
                                break;
                            }
                        case "Owner":
                            {
                                userManager.Create(u, "pZm.7Yuiie.39Tav,3dAq98,cva5,HuB.0");
                                userManager.AddToRole(u.Id, RoleTypes.Owner.ToString());
                                break;
                            }
                    }
                }
            }

            #endregion

            #region Stocks

            var stock = new Stock()
            {
                StockTranslates = new List<StockTranslate>()
                {
                    new StockTranslate()
                    {
                        Language = english,
                        StockTitle = "Opening store!",
                        StockDescription = "Discount on all products 20% within a week from the date of opening.",
                        ImageFilename = "open-shop-stock-en.jpg"
                    },
                    new StockTranslate()
                    {
                        Language = russion,
                        StockTitle = "Открытие магазина!",
                        StockDescription = "Скидка на все товары 20% в течение недели со дня открытия.",
                        ImageFilename = "open-shop-stock-ru.jpg"
                    }
                },
                Discount = 20,
                StartDate = DateTime.UtcNow,
                FinishDate = DateTime.UtcNow.AddDays(7)
            };

            context.Stocks.Add(stock);

            #endregion

            #region Categories

            var dmCategory = new Category()
            {
                CategoryTranslates = new List<CategoryTranslate>()
                {
                    new CategoryTranslate()
                    {
                        CategoryName = "Dionaea Muscipula",
                        CategoryDescription = "Venus flytrap (Dionaea muscipula) is a small carnivorous plant with an outstanding reputation. " +
                            "Charles Darwin himself described it as one of the most beautiful plants in the world." +
                            " The Venus flytrap is able to capture live insects using its modified leaves as traps. " +
                            "This ability allows it to grow in soils with a nitrogen deficiency. " +
                            "It is one of the few plants that are capable of such lightning movements.",
                        Language = english,
                        PageDescription = "Category - Dionaea Muscipula",
                        PageKeywords = "Dionaea Muscipula, Dionaea, Muscipula, Carnivorous plants, plants"
                    },
                    new CategoryTranslate()
                    {
                        CategoryName = "Венерина Мухоловка",
                        CategoryDescription = "Венерина мухоловка (Dionaea muscipula) – небольшое хищное растение с выдающейся репутацией. " +
                            "Сам Чарльз Дарвин описал его как одно из самых прекрасных растений мира." + 
                            "Венерина мухоловка в состоянии захватывать живых насекомых, используя свои модифицированные листья в качестве ловушек. " +
                            "Эта способность позволяет ей расти в почвах с дефицитом азота. Она является одним из немногих растений, " +
                            "которые способны на столь молниеносные движения.",
                        Language = russion,
                        PageDescription = "Категория - Венерина Мухоловка",
                        PageKeywords = "Венерина Мухоловка, Венерина, Мухоловка, Росянковые, Хищные растения, растения"
                    }
                },
                CategoryImageFilename = "venus-fly-trap-category.jpg",
                ModifiedDate = DateTime.UtcNow,
                Stock = stock
            };
            var drCategory = new Category()
            {
                CategoryTranslates = new List<CategoryTranslate>()
                {
                    new CategoryTranslate()
                    {
                        CategoryName = "Drosera",
                        CategoryDescription = "Drosera belongs to the genus of carnivorous plants of the Droseraceae family." +
                            " Its spread across the planet is surprising. It is found in all parts of the world, except Antarctica. " +
                            "Most of Drosera in Australia and New Zealand. It owes its vitality to the special structure and method " +
                            "of obtaining food. The main matter of life of the insectivorous predator is hunting. There are about 200 " +
                            "species of this plant. The Latin name \"Drosera\" gave C. Linnaeus to the plant, which in Russian means \"Dew\".",
                        Language = english,
                        PageDescription = "Category - Drosera",
                        PageKeywords = "Drosera, Carnivorous plants, Carnivorous, plants"
                    },
                    new CategoryTranslate()
                    {
                        CategoryName = "Росянка",
                        CategoryDescription = "Росянка (Drosera) относится к роду плотоядных растений семейства Росянковые (Droseraceae). " +
                            "Ее распространение по планете удивляет. Оно встречается во всех частях Света, кроме Антарктиды. " +
                            "Больше всего Росянок в Австралии и Новой Зеландии. Своей живучестью оно обязано особому строению и " +
                            "способу добывания пищи. Главное дело жизни насекомоядной хищницы – охота. Насчитывают около 200 видов этого растения. " +
                            "Латинское название «Drosera» растению дал К. Линней, что в переводе на русский означает «Роса».",
                        Language = russion,
                        PageDescription = "Категория - Росянка",
                        PageKeywords = "Росянка, Хищные растения, растения, росянковые"
                    }
                },
                CategoryImageFilename = "drosera-category.jpg",
                ModifiedDate = DateTime.UtcNow,
                Stock = stock
            };
            var npCategory = new Category()
            {
                CategoryTranslates = new List<CategoryTranslate>()
                {
                    new CategoryTranslate()
                    {
                        CategoryName = "Nepenthes",
                        CategoryDescription = "Nepenthes is an unusual representative of a flora with a predatory character. " +
                            "In addition to the usual food, he needs insects, which he digests in his jugs. The genus belongs to the " +
                            "family of the same name Nepenthaceae. It is found in tropical Asia and the Pacific basin " +
                            "(from Kalimantan to Australia and Madagascar). Amazing exotic will certainly attract the attention and become " +
                            "the universal favorite.",
                        Language = english,
                        PageDescription = "Category - Nepenthes",
                        PageKeywords = "Nepenthes, Carnivorous plants, plants"
                    },
                    new CategoryTranslate()
                    {
                        CategoryName = "Непентес",
                        CategoryDescription = "Непентес – необычный представитель флоры с хищным характером. " +
                            "Кроме привычного питания, он нуждается в насекомых, которых переваривает в своих кувшинчиках. " +
                            "Род относится к одноименному семейству Непентовые. Встречается в тропической Азии и Тихоокеанском " +
                            "бассейне (от Калимантана до Австралии и Мадагаскара). Удивительный экзот непременно будет приковывать " +
                            "внимание и станет всеобщим любимцем.",
                        Language = russion,
                        PageDescription = "Категория - Непентес",
                        PageKeywords = "Непентес, Кувшиночник, Хищные растения, растения"
                    }
                },
                CategoryImageFilename = "nepenthes-category.jpg",
                ModifiedDate = DateTime.UtcNow,
                Stock = stock
            };
            var srCategory = new Category()
            {
                CategoryTranslates = new List<CategoryTranslate>()
                {
                    new CategoryTranslate()
                    {
                        CategoryName = "Sarracenia",
                        CategoryDescription = "Саррацения — это болотное, корневищное, травянистое растение является многолетником. " +
                            "Оно входит в число наиболее больших плотоядных растений. Его листочки, находящиеся снизу, чешуйчатые. " +
                            "Короткочерешковые ловчие листочки, отличающиеся достаточно большим размером, собраны в розетку. " +
                            "Они возвышаются над самим растением и строением чем-то напоминают урну с довольно широким отверстием сверху " +
                            "либо трубковидный кувшин.",
                        Language = english,
                        PageDescription = "Category - Sarracenia",
                        PageKeywords = "Sarracenia, Carnivorous plants, carnivorous, plants"
                    },
                    new CategoryTranslate()
                    {
                        CategoryName = "Саррацения",
                        CategoryDescription = "Sarracenia is a marsh, rhizomatous, herbaceous plant is a perennial. " +
                            "It is among the largest carnivorous plants. Its bottom leaves are scaly. Korotkocheriskovye trap leaves, " +
                            "differing in sufficiently large size, collected in the outlet. They rise above the plant itself and the " +
                            "structure somewhat resembles an urn with a rather wide opening at the top or a tubular jug.",
                        Language = russion,
                        PageDescription = "Категория - Саррацения",
                        PageKeywords = "Саррацения, Хищные растения, хищные, растения"
                    }
                },
                CategoryImageFilename = "sarracenia-category.jpg",
                ModifiedDate = DateTime.UtcNow,
                Stock = stock
            };
            var pnCategory = new Category()
            {
                CategoryTranslates = new List<CategoryTranslate>()
                {
                    new CategoryTranslate()
                    {
                        CategoryName = "Pinguicula",
                        CategoryDescription = "Pinguícula is a genus of perennial insectivorous plants of the Bubyllate family. " +
                            "The name of the plant comes from the Latin \"pinguis\" - \"fat\", because of the fleshy, oily shiny juicy " +
                            "leaves; it indicates that the surface of the leaves is covered with thousands of the smallest glands, " +
                            "secreting mucous secretion.",
                        Language = english,
                        PageDescription = "Category - Pinguicula",
                        PageKeywords = "Pinguicula, Carnivorous plants, Carnivorous, plants"
                    },
                    new CategoryTranslate()
                    {
                        CategoryName = "Жирянка",
                        CategoryDescription = "Жирянка (Pinguícula) — род многолетних насекомоядных растений семейства Пузырчатковые. " +
                            "Название растения происходит от латинского \"pinguis\" – \"жирный\", \"жир\", из-за мясистых, маслянисто блестящих " +
                            "сочных листьев; оно указывает на то, что поверхность листьев покрыта тысячами мельчайших железок, выделяющих " +
                            "слизистый секрет.",
                        Language = russion,
                        PageDescription = "Категория - Жирянка",
                        PageKeywords = "Жирянка, Хищные растения, хищные, растения"
                    }
                },
                CategoryImageFilename = "pinguicula-category.jpg",
                ModifiedDate = DateTime.UtcNow,
                Stock = stock
            };
            var utCategory = new Category()
            {
                CategoryTranslates = new List<CategoryTranslate>()
                {
                    new CategoryTranslate()
                    {
                        CategoryName = "Utricularia",
                        CategoryDescription = "Get acquainted with the Utricularia - a rapid predator from the world of plants, distributed " +
                            "almost throughout the planet, except Antarctica. This aquatic insectivorous plant is covered with so-called " +
                            "trapping bubbles, sucking the victim in less than a millisecond. Each such bubble has a hole through which small " +
                            "animals can easily fall into the trap, but cannot get out of it.",
                        Language = english,
                        PageDescription = "Category - Utricularia",
                        PageKeywords = "Utricularia, Carnivorous plants, Carnivorous, plants"
                    },
                    new CategoryTranslate()
                    {
                        CategoryName = "Пузырчатка",
                        CategoryDescription = "Знакомьтесь с пузырчаткой — стремительным хищником из мира растений, распространенном практически " +
                            "по всей планете, кроме Антарктиды. Это водное насекомоядное растение покрыто так называемыми ловчими пузырьками, " +
                            "засасывающих жертву меньше, чем за миллисекунду. Каждый такой пузырек имеет отверстие, с помощью которого мелкие " +
                            "животные могут легко попадать в ловушку, но не могут из неё выбраться.",
                        Language = russion,
                        PageDescription = "Категория - Пузырчатка",
                        PageKeywords = "Пузырчатка, Хищные растения, хищные, растения"
                    }
                },
                CategoryImageFilename = "utricularia-category.jpg",
                ModifiedDate = DateTime.UtcNow,
                Stock = stock
            };
            var dcCategory = new Category()
            {
                CategoryTranslates = new List<CategoryTranslate>()
                {
                    new CategoryTranslate()
                    {
                        CategoryName = "Darlingtonia Californica",
                        CategoryDescription = "The predatory darlingtonia plant, whose leaves resemble a cobra prepared " +
                            "for an attack with a loose hood, is considered a rare species of the sarracion family and is carefully " +
                            "protected according to the Washington Convention. The area of darlingtonia in the wild is very limited - it is a " +
                            "relatively small area between the US states of Oregon and California.",
                        Language = english,
                        PageDescription = "Category - Darlingtonia Californica",
                        PageKeywords = "Darlingtonia Californica, Darlingtonia, Californica, Carnivorous plants, plants"
                    },
                    new CategoryTranslate()
                    {
                        CategoryName = "Дарлингтония Калифорнийская",
                        CategoryDescription = "Хищное растение дарлингтония, листья которой напоминают приготовившуюся к нападению кобру " +
                            "с распущенным капюшоном, считается редким родом семейства саррацениевых и тщательно охраняется согласно " +
                            "Вашингтонской Конвенции. Область распространения дарлингтонии в дикой природе очень ограничена – это относительно " +
                            "небольшой район между американскими штатами Орегон и Калифорния.",
                        Language = russion,
                        PageDescription = "Категория - Дарлингтония Калифорнийская",
                        PageKeywords = "Дарлингтония Калифорнийская, Дарлингтония, Калифорнийская, Хищные растения, растения"
                    }
                },
                CategoryImageFilename = "darlingtonia-californica-category.jpg",
                ModifiedDate = DateTime.UtcNow,
                Stock = stock
            };
            var cfCategory = new Category()
            {
                CategoryTranslates = new List<CategoryTranslate>()
                {
                    new CategoryTranslate()
                    {
                        CategoryName = "Cephalotus Follicularis",
                        CategoryDescription = "Cephalotus is a perennial, evergreen, predatory, insectivorous plant. " +
                            "Unlike most fellow predators, cephalotus has 2 different types of leaves. Some are used for photosynthesis, " +
                            "while others catch insects. Young plants first develop photosynthetic leaves, and then predatory ones appear. " +
                            "\"Predatory\" leaves are jugs, covered with lids. Lids protect the pitchers from filling with rainwater. " +
                            "At the bottom of the pitchers is the digestive juice of the plant.",
                        Language = english,
                        PageDescription = "Category - Cephalotus Follicularis",
                        PageKeywords = "Cephalotus Follicularis, Carnivorous plants, plants, follicularis"
                    },
                    new CategoryTranslate()
                    {
                        CategoryName = "Цефалотус",
                        CategoryDescription = "Цефалотус - многолетнее, вечнозеленое, хищное, насекомоядное растение. " +
                            "В отличие от большинства собратьев – хищников цефалотус имеет 2 разных типа листьев. " +
                            "Одни служат для фотосинтеза, а другие ловят насекомых. У молодых растений сперва развиваются фотосинтезирующие листья, " +
                            "а затем появляются и хищные. «Хищные» листья представляют собой кувшинчики, прикрытые крышками. " +
                            "Крышечки предохраняют кувшины от наполнения дождевой водой. На дне кувшинов находится пищеварительный сок растения.",
                        Language = russion,
                        PageDescription = "Категория - Цефалотус",
                        PageKeywords = "Цефалотус, Хищные растения австралии, Хищные растения, растения"
                    }
                },
                CategoryImageFilename = "cephalotus-category.jpg",
                ModifiedDate = DateTime.UtcNow,
                Stock = stock
            };
            var seedCategory = new Category()
            {
                CategoryTranslates = new List<CategoryTranslate>()
                {
                    new CategoryTranslate()
                    {
                        CategoryName = "Carnivorous plant's seeds",
                        CategoryDescription = "In this category you can find the seeds of carnivorous plants that interest you!",
                        Language = english,
                        PageDescription = "Category - Carnivorous plant's seeds",
                        PageKeywords = "Carnivorous plant's seeds, Carnivorous, plants, seeds"
                    },
                    new CategoryTranslate()
                    {
                        CategoryName = "Семена хищных растений",
                        CategoryDescription = "В этой категории вы можете найти семена хищных растений, которые вас интересуют!",
                        Language = russion,
                        PageDescription = "Категория - Семена хищных растений",
                        PageKeywords = "Семена хищных растений, Хищные растения, растения"
                    }
                },
                CategoryImageFilename = "seeds-category.jpg",
                ModifiedDate = DateTime.UtcNow,
                Stock = stock
            };
            var relatedCategory = new Category()
            {
                CategoryTranslates = new List<CategoryTranslate>()
                {
                    new CategoryTranslate()
                    {
                        CategoryName = "Related products",
                        CategoryDescription = "Substrates, substrate components, pots, water and preparations for carnivorous plants.",
                        Language = english,
                        PageDescription = "Category - Related products",
                        PageKeywords = "Related products, goods, products for predatory plants, plants, preparations for plants"
                    },
                    new CategoryTranslate()
                    {
                        CategoryName = "Сопутствующие товары",
                        CategoryDescription = "Субстраты, компоненты субстрата, горшки, дист. вода и препараты для хищных растений.",
                        Language = russion,
                        PageDescription = "Категория - Сопутствующие товары",
                        PageKeywords = "Сопутствующие товары, товары, товары для хищных растений, растения, препараты для растений"
                    }
                },
                CategoryImageFilename = "related-category.jpg",
                ModifiedDate = DateTime.UtcNow,
                Stock = stock
            };

            context.Categories.AddRange(new List<Category>() { dmCategory,
                drCategory, npCategory, srCategory, pnCategory, utCategory, dcCategory, cfCategory, seedCategory, relatedCategory});

            #endregion

            #region Articles

            var articles = new List<Article>()
            {
                new Article()
                {
                    ArticleTranslates = new List<ArticleTranslate>()
                    {
                        new ArticleTranslate()
                        {
                            ArticleTitle = "About Venus Flytrap",
                            ArticleText = "Venus flytrap (lat. Dionaea muscipula) is a species of carnivorous plants from the monotype " +
                                "Dionea genus of the Droseraceae family.\n\n Venus flytrap - plant of the marshy areas of the eastern " +
                                "coast of the United States of America (North and South Carolina). The Venus flytrap catches its prey " +
                                "(insects, arachnids) with the help of a specialized trap apparatus, formed from the marginal parts of " +
                                "the leaves. The slamming of the trap is initiated by thin trigger (sensitive) hairs on the leaf surface. " +
                                "To slam the trap apparatus, it is necessary to exert a mechanical impact on at least two hairs on a sheet with an " +
                                "interval of not more than 20 seconds. Such redundancy provides protection against accidental slamming in response " +
                                "to the fall of objects with no nutritional value (raindrops, debris, etc.). Moreover, digestion begins at least" +
                                " after five-fold stimulation of sensitive hairs.",
                            Language = english,
                            PageDescription = "Article - About Venus Flytrap",
                            PageKeywords = "About Venus Flytrap, About Venus Fly trap, About, Venus Flytrap, Dionaea, muscipula"
                        },
                        new ArticleTranslate()
                        {
                            ArticleTitle = "О Венериной Мухоловки",
                            ArticleText = "Вене́рина мухоло́вка (лат. Dionaea muscipula) — вид хищных растений из монотипного рода Дионея семейства " +
                                "Росянковые (Droseraceae).\n\n Венерина мухоловка - растение болотистых областей восточного побережья Соединенных " +
                                "Штатов Америки (Северная и Южная Каролины). Венерина мухоловка ловит своих жертв (насекомых, паукообразных) с " +
                                "помощью специализированного ловчего аппарата, образованного из краевых частей листьев. Захлопывание ловушки " +
                                "инициируется тоненькими триггерными (чувствительными) волосками на поверхности листьев. Для захлопывания " +
                                "ловчего аппарата необходимо оказать механическое воздействие минимум на два волоска на листе с интервалом не " +
                                "более 20 секунд. Такая избыточность обеспечивает защиту от случайного захлопывания в ответ на падение объектов, " +
                                "не имеющих питательной ценности (капли дождя, мусор и т. д.). Более того, переваривание начинается как минимум " +
                                "после пятикратной стимуляции чувствительных волосков.",
                            Language = russion,
                            PageDescription = "Статья - О Венериной Мухоловки",
                            PageKeywords = "О Венериной Мухоловки, Венерина Мухоловка, мухоловка"
                        }
                    },
                    Category = dmCategory,
                    ModifiedDate = DateTime.UtcNow,
                    ImageFilename = "about-dm-article.jpg"
                },
                /*new Article()
                {
                    ArticleTranslates = new List<ArticleTranslate>()
                    {
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = english,
                            PageDescription = "",
                            PageKeywords = ""
                        },
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = russion,
                            PageDescription = "",
                            PageKeywords = ""
                        }
                    },
                    Category = drCategory,
                    DateTime = DateTime.UtcNow,
                    ImageFilename = ""
                },
                new Article()
                {
                    ArticleTranslates = new List<ArticleTranslate>()
                    {
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = english,
                            PageDescription = "",
                            PageKeywords = ""
                        },
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = russion,
                            PageDescription = "",
                            PageKeywords = ""
                        }
                    },
                    Category = npCategory,
                    DateTime = DateTime.UtcNow,
                    ImageFilename = ""
                },
                new Article()
                {
                    ArticleTranslates = new List<ArticleTranslate>()
                    {
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = english,
                            PageDescription = "",
                            PageKeywords = ""
                        },
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = russion,
                            PageDescription = "",
                            PageKeywords = ""
                        }
                    },
                    Category = srCategory,
                    DateTime = DateTime.UtcNow,
                    ImageFilename = ""
                },
                new Article()
                {
                    ArticleTranslates = new List<ArticleTranslate>()
                    {
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = english,
                            PageDescription = "",
                            PageKeywords = ""
                        },
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = russion,
                            PageDescription = "",
                            PageKeywords = ""
                        }
                    },
                    Category = pnCategory,
                    DateTime = DateTime.UtcNow,
                    ImageFilename = ""
                },
                new Article()
                {
                    ArticleTranslates = new List<ArticleTranslate>()
                    {
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = english,
                            PageDescription = "",
                            PageKeywords = ""
                        },
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = russion,
                            PageDescription = "",
                            PageKeywords = ""
                        }
                    },
                    Category = utCategory,
                    DateTime = DateTime.UtcNow,
                    ImageFilename = ""
                },
                new Article()
                {
                    ArticleTranslates = new List<ArticleTranslate>()
                    {
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = english,
                            PageDescription = "",
                            PageKeywords = ""
                        },
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = russion,
                            PageDescription = "",
                            PageKeywords = ""
                        }
                    },
                    Category = dcCategory,
                    DateTime = DateTime.UtcNow,
                    ImageFilename = ""
                },
                new Article()
                {
                    ArticleTranslates = new List<ArticleTranslate>()
                    {
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = english,
                            PageDescription = "",
                            PageKeywords = ""
                        },
                        new ArticleTranslate()
                        {
                            ArticleTitle = "",
                            ArticleText = "",
                            Language = russion,
                            PageDescription = "",
                            PageKeywords = ""
                        }
                    },
                    Category = cfCategory,
                    DateTime = DateTime.UtcNow,
                    ImageFilename = ""
                }*/
            };

            context.Articles.AddRange(articles);

            #endregion

            #region DeliveryTypes

            var deliveryTypes = new List<DeliveryType>()
            {
                new DeliveryType()
                {
                    DeliveryTypeTranslates = new List<DeliveryTypeTranslate>()
                    {
                        new DeliveryTypeTranslate()
                        {
                            Name = "Mail",
                            Description = "Belpost mail delivery.",
                            Availability = true,
                            Language = english,
                            Price = 5
                        },
                        new DeliveryTypeTranslate()
                        {
                            Name = "Почта",
                            Description = "Доставка Белпочтой.",
                            Availability = true,
                            Language = russion,
                            Price = 11
                        }
                    },
                    DeliveryTypeImageFilename = "belpost.jpg"
                },
                new DeliveryType()
                {
                    DeliveryTypeTranslates = new List<DeliveryTypeTranslate>()
                    {
                        new DeliveryTypeTranslate()
                        {
                            Name = "Courier",
                            Description = "Express delivery in Minsk.",
                            Availability = true,
                            Language = english,
                            Price = 5
                        },
                        new DeliveryTypeTranslate()
                        {
                            Name = "Курьер",
                            Description = "Курьерская доставка по Минску.",
                            Availability = true,
                            Language = russion,
                            Price = 11
                        }
                    },
                    DeliveryTypeImageFilename = "courier.jpg"
                },
                new DeliveryType()
                {
                    DeliveryTypeTranslates = new List<DeliveryTypeTranslate>()
                    {
                        new DeliveryTypeTranslate()
                        {
                            Name = "Pickup from storage",
                            Description = "Pickup from storage in Minsk.",
                            Availability = true,
                            Language = english,
                            Price = 0
                        },
                        new DeliveryTypeTranslate()
                        {
                            Name = "Самовывоз со склада",
                            Description = "Самовывоз со склада в Минске.",
                            Availability = true,
                            Language = russion,
                            Price = 0
                        }
                    },
                    DeliveryTypeImageFilename = "pickup.jpg"
                }
            };

            context.DeliveryTypes.AddRange(deliveryTypes);

            #endregion

            #region Dimensions

            // TODO

            #endregion

            #region OrderStatuses

            // TODO

            #endregion

            #region PaymentMethods

            // TODO

            #endregion

            #region Providers

            // TODO

            #endregion

            #region Products

            // TODO

            #endregion

            #region ShopContacts

            var contact = new ShopContact()
            {
                Email = "venusflytrapshop@gmail.com",
                MobilePhone = "+375259507009",
                ModifiedDate = DateTime.UtcNow,
                WorkTime = "9:00 - 20:00",
                ShopContactTranslates = new List<ShopContactTranslate>()
                {
                    new ShopContactTranslate()
                    {
                        Language = russion,
                        Location = "Республика Беларусь, г. Минск, ул. Леонида Беды 2б",
                        Registration = "В торговом реестре с 12 июня 2019г. УНП 000000000. Регистрация № 000000000, 12.06.2019, Мингорисполком"
                    },
                    new ShopContactTranslate()
                    {
                        Language = english,
                        Location = "Republic of Belarus, Minsk, st. Leonid Beda 2b",
                        Registration = "In the trade register from June 12, 2019. UNP 000000000. Registration number 000000000, 12.06.2019, Minsk City Executive Committee"
                    }
                }
            };

            context.ShopContacts.Add(contact);

            #endregion

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
