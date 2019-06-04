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
    internal class DbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
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
                    Email = "admin@gmail.com",
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
                    Email = "manager@gmail.com",
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
                FinishDate = DateTime.UtcNow.AddDays(7),
                IsActive = true
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
                Stock = stock,
                ProductsCount = 1,
                ArticlesCount = 1
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
                Stock = stock,
                ProductsCount = 1,
                ArticlesCount = 1
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
                Stock = stock,
                ProductsCount = 1,
                ArticlesCount = 1
            };
            var srCategory = new Category()
            {
                CategoryTranslates = new List<CategoryTranslate>()
                {
                    new CategoryTranslate()
                    {
                        CategoryName = "Sarracenia",
                        CategoryDescription = "Sarracenia is a marsh, rhizomatous, herbaceous plant is a perennial. " +
                            "It is among the largest carnivorous plants. Its bottom leaves are scaly. Korotkocheriskovye trap leaves, " +
                            "differing in sufficiently large size, collected in the outlet. They rise above the plant itself and the " +
                            "structure somewhat resembles an urn with a rather wide opening at the top or a tubular jug.",
                        Language = english,
                        PageDescription = "Category - Sarracenia",
                        PageKeywords = "Sarracenia, Carnivorous plants, carnivorous, plants"
                    },
                    new CategoryTranslate()
                    {
                        CategoryName = "Саррацения",
                        CategoryDescription = "Саррацения — это болотное, корневищное, травянистое растение является многолетником. " +
                            "Оно входит в число наиболее больших плотоядных растений. Его листочки, находящиеся снизу, чешуйчатые. " +
                            "Короткочерешковые ловчие листочки, отличающиеся достаточно большим размером, собраны в розетку. " +
                            "Они возвышаются над самим растением и строением чем-то напоминают урну с довольно широким отверстием сверху " +
                            "либо трубковидный кувшин.",
                        Language = russion,
                        PageDescription = "Категория - Саррацения",
                        PageKeywords = "Саррацения, Хищные растения, хищные, растения"
                    }
                },
                CategoryImageFilename = "sarracenia-category.jpg",
                ModifiedDate = DateTime.UtcNow,
                Stock = stock,
                ProductsCount = 1,
                ArticlesCount = 1
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
                Stock = stock,
                ProductsCount = 1,
                ArticlesCount = 1
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
                Stock = stock,
                ProductsCount = 1,
                ArticlesCount = 1
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
                Stock = stock,
                ProductsCount = 1,
                ArticlesCount = 1
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
                Stock = stock,
                ProductsCount = 1,
                ArticlesCount = 1
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
                Stock = stock,
                ProductsCount = 1,
                ArticlesCount = 1
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
                Stock = stock,
                ProductsCount = 1,
                ArticlesCount = 1
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

            var s = new Dimension()
            {
                DimensionTranslates = new List<DimensionTranslate>()
                {
                    new DimensionTranslate()
                    {
                        DimensionName = "S",
                        DimensionDescription = "Small size plant.",
                        Language = english
                    },
                    new DimensionTranslate()
                    {
                        DimensionName = "S",
                        DimensionDescription = "Маленькое растение.",
                        Language = russion
                    }
                }
            };

            var m = new Dimension()
            {
                DimensionTranslates = new List<DimensionTranslate>()
                {
                    new DimensionTranslate()
                    {
                        DimensionName = "M",
                        DimensionDescription = "Medium size plant.",
                        Language = english
                    },
                    new DimensionTranslate()
                    {
                        DimensionName = "M",
                        DimensionDescription = "Среднее растение.",
                        Language = russion
                    }
                }
            };

            var l = new Dimension()
            {
                DimensionTranslates = new List<DimensionTranslate>()
                {
                    new DimensionTranslate()
                    {
                        DimensionName = "L",
                        DimensionDescription = "Large size plant.",
                        Language = english
                    },
                    new DimensionTranslate()
                    {
                        DimensionName = "L",
                        DimensionDescription = "Большое растение.",
                        Language = russion
                    }
                }
            };

            var seedSmall = new Dimension()
            {
                DimensionTranslates = new List<DimensionTranslate>()
                {
                    new DimensionTranslate()
                    {
                        DimensionName = "Small packet",
                        DimensionDescription = "5 seeds.",
                        Language = english
                    },
                    new DimensionTranslate()
                    {
                        DimensionName = "Маленький пакет",
                        DimensionDescription = "5 семян.",
                        Language = russion
                    }
                }
            };

            var seedMedium = new Dimension()
            {
                DimensionTranslates = new List<DimensionTranslate>()
                {
                    new DimensionTranslate()
                    {
                        DimensionName = "Medium packet",
                        DimensionDescription = "10 seeds.",
                        Language = english
                    },
                    new DimensionTranslate()
                    {
                        DimensionName = "Средний пакет",
                        DimensionDescription = "10 семян.",
                        Language = russion
                    }
                }
            };

            var seedLarge = new Dimension()
            {
                DimensionTranslates = new List<DimensionTranslate>()
                {
                    new DimensionTranslate()
                    {
                        DimensionName = "Large packet",
                        DimensionDescription = "15 seeds.",
                        Language = english
                    },
                    new DimensionTranslate()
                    {
                        DimensionName = "Большой пакет",
                        DimensionDescription = "15 семян.",
                        Language = russion
                    }
                }
            };

            var substratSmall = new Dimension()
            {
                DimensionTranslates = new List<DimensionTranslate>()
                {
                    new DimensionTranslate()
                    {
                        DimensionName = "Small packet",
                        DimensionDescription = "1 liter.",
                        Language = english
                    },
                    new DimensionTranslate()
                    {
                        DimensionName = "Маленький пакет",
                        DimensionDescription = "1 литр",
                        Language = russion
                    }
                }
            };

            var substratMedium = new Dimension()
            {
                DimensionTranslates = new List<DimensionTranslate>()
                {
                    new DimensionTranslate()
                    {
                        DimensionName = "Medium packet",
                        DimensionDescription = "2 liter",
                        Language = english
                    },
                    new DimensionTranslate()
                    {
                        DimensionName = "Средний пакет",
                        DimensionDescription = "2 литра",
                        Language = russion
                    }
                }
            };

            var substratLarge = new Dimension()
            {
                DimensionTranslates = new List<DimensionTranslate>()
                {
                    new DimensionTranslate()
                    {
                        DimensionName = "Large packet",
                        DimensionDescription = "3 liter",
                        Language = english
                    },
                    new DimensionTranslate()
                    {
                        DimensionName = "Большой пакет",
                        DimensionDescription = "3 литра",
                        Language = russion
                    }
                }
            };

            context.Dimensions.AddRange(new List<Dimension>() { s, l, m, seedSmall, seedMedium, seedLarge, substratSmall, substratMedium, substratLarge });

            #endregion

            #region OrderStatuses

            // TODO

            #endregion

            #region PaymentMethods

            // TODO

            #endregion

            #region Providers

            var provider = new Provider()
            {
                ImageFilename = "favicon.png",
                ProviderTranslates = new List<ProviderTranslate>()
                {
                    new ProviderTranslate()
                    {
                        Language = english,
                        ProviderName = "Venusflytrap.com",
                        ProviderDescription = "Venusflytrap.com - best carnivorous plants in Europe!"
                    },
                    new ProviderTranslate()
                    {
                        Language = russion,
                        ProviderName = "Venusflytrap.com",
                        ProviderDescription = "Venusflytrap.com - лучший производитель хищных растений в Европе!"
                    }
                }
            };

            context.Providers.AddRange(new List<Provider>() { provider });

            #endregion

            #region Products

            var products = new List<Product>()
            {
                new Product()
                {
                    Category = dmCategory,
                    ProductImageFilename = "dm-typical.jpg",
                    ModifiedDate = DateTime.UtcNow,
                    Provider = provider,
                    VendorCode = "DM000",
                    Stock = null,
                    StockId = null,
                    ProductParameters = new List<ProductParameter>()
                    {
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = s,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 0
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 0
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = m,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 1
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 2
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = l,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 2
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 4
                                }
                            }
                        }
                    },
                    ProductImages = new List<ProductImage>()
                    {
                        new ProductImage()
                        {
                            Filename = "dm-typical-1.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "dm-typical-2.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "dm-typical-3.jpg"
                        }
                    },
                    ProductTranslates = new List<ProductTranslate>()
                    {
                        new ProductTranslate()
                        {
                            Language = english,
                            ProductName = "Dionaea muscipula 'Typical'",
                            ProductDescription = "The natural form of Dionei, the leaves are light green, the color of the trap varies from light green to red, the cilia are long.",
                            Price = 7.5M,
                            PageDescription = "Product - Dionaea muscipula typical",
                            PageKeywords = "product, dionaea muscipula typical, typical, dionaea"
                        },
                        new ProductTranslate()
                        {
                            Language = russion,
                            ProductName = "Венерина мухоловка (дионея) 'Типичная'",
                            ProductDescription = "Природная форма дионеи, листья светло - зеленые, цвет ловушки от светло-зеленого до красного, реснички длинные.",
                            Price = 15,
                            PageDescription = "Товар - Венерина Мухоловка типичная",
                            PageKeywords = "Товар, венерина мухоловка типичная, мухоловка, дионея, типичная"
                        }
                    }
                },
                new Product()
                {
                    Category = drCategory,
                    ProductImageFilename = "dr-rotundifolia.jpg",
                    ModifiedDate = DateTime.UtcNow,
                    Provider = provider,
                    VendorCode = "DR000",
                    Stock = null,
                    StockId = null,
                    ProductParameters = new List<ProductParameter>()
                    {
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = s,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 0
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 0
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = m,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 1
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 2
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = l,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 3
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 6
                                }
                            }
                        }
                    },
                    ProductImages = new List<ProductImage>()
                    {
                        new ProductImage()
                        {
                            Filename = "dr-rotundifolia-1.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "dr-rotundifolia-2.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "dr-rotundifolia-3.jpg"
                        }
                    },
                    ProductTranslates = new List<ProductTranslate>()
                    {
                        new ProductTranslate()
                        {
                            Language = english,
                            ProductName = "Drosera Rotundifolia",
                            ProductDescription = "The drosera is of a temperate climate, the leaves are collected in a rosette, of medium length, at the ends are round with many cilia at the ends of which are sticky droplets. Leaf color from green to red.",
                            Price = 10M,
                            PageDescription = "Product - Drosera Rotundifolia",
                            PageKeywords = "product, Rotundifolia, drosera, drosera rotundifolia"
                        },
                        new ProductTranslate()
                        {
                            Language = russion,
                            ProductName = "Росянка Круглолистая",
                            ProductDescription = "Росянка умеренного климата, листия собраны в розетку, средней длины, на концах имеют круглую форму с множеством ресничек на концах которых липкие капельки. Цвет листьев от зеленого до красного.",
                            Price = 20,
                            PageDescription = "Товар - Росянка Круглолистая",
                            PageKeywords = "товар, Росянка Круглолистая, Росянка, Круглолистая"
                        }
                    }
                },
                new Product()
                {
                    Category = npCategory,
                    ProductImageFilename = "np-alata.jpg",
                    ModifiedDate = DateTime.UtcNow,
                    Provider = provider,
                    VendorCode = "NP000",
                    Stock = null,
                    StockId = null,
                    ProductParameters = new List<ProductParameter>()
                    {
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = s,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 0
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 0
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = m,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 2
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 4
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = l,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 4
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 8
                                }
                            }
                        }
                    },
                    ProductImages = new List<ProductImage>()
                    {
                        new ProductImage()
                        {
                            Filename = "np-alata-1.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "np-alata-2.jpg"
                        }
                    },
                    ProductTranslates = new List<ProductTranslate>()
                    {
                        new ProductTranslate()
                        {
                            Language = english,
                            ProductName = "Nepenthes Alata",
                            ProductDescription = "Nepenthes 'Alata' grows large, impressive size. Very spectacular plant that will be a great decoration in your interior. It has large green leaves turning into a jug-trap, the color of the jug from green to light red.",
                            Price = 10M,
                            PageDescription = "Product - Nepenthes Alata",
                            PageKeywords = "product, Nepenthes Alata, Nepenthes, Alata"
                        },
                        new ProductTranslate()
                        {
                            Language = russion,
                            ProductName = "Непентес Алата",
                            ProductDescription = "Непентес 'Алата' вырастает крупных, внушительных размеров. Очень эффектное растение, которое станет прекрасным украшением в Вашем интерьере. Имеет крупные зеленые листья переходящие в кувшин-ловушку, цвет кувшина от зеленого до светло-красного.",
                            Price = 20,
                            PageDescription = "Товар - Непентес Алата",
                            PageKeywords = "товар, непентес алата, непентес, алата"
                        }
                    }
                },
                new Product()
                {
                    Category = srCategory,
                    ProductImageFilename = "sr-alata.jpg",
                    ModifiedDate = DateTime.UtcNow,
                    Provider = provider,
                    VendorCode = "SR000",
                    Stock = null,
                    StockId = null,
                    ProductParameters = new List<ProductParameter>()
                    {
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = s,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 0
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 0
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = m,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 2
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 4
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = l,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 5
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 10
                                }
                            }
                        }
                    },
                    ProductImages = new List<ProductImage>()
                    {
                        new ProductImage()
                        {
                            Filename = "sr-alata-1.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "sr-alata-2.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "sr-alata-3.jpg"
                        }
                    },
                    ProductTranslates = new List<ProductTranslate>()
                    {
                        new ProductTranslate()
                        {
                            Language = english,
                            ProductName = "Sarracenia Alata",
                            ProductDescription = "Sarracenia are perennial herbaceous plants with leaves twisted into jar-traps growing on the top of the rhizome. The leaves are elongated, narrow at the bottom and slightly widening at the top and a part of the sheet forms a cover. Inside the leaves are digestive fluids, with which the plant digests the prey. The prey is attracted by the sweetish nectar produced by the trap leaves. Unlike other predatory plants, the lid does not slam when the insect gets inside, the victim simply drowns in the accumulated liquid, gradually digesting. Flowers solitary, on a long peduncle, with a diameter of up to 10 cm, depending on the type of their color can be red, purple, purple or yellowish.",
                            Price = 12.5M,
                            PageDescription = "Product - Sarracenia Alata",
                            PageKeywords = "Product, Sarracenia Alata, Sarracenia, Alata"
                        },
                        new ProductTranslate()
                        {
                            Language = russion,
                            ProductName = "Саррацения Алата (Alata)",
                            ProductDescription = "Саррацения – это многолетние травянистые растения с листьями, закрученными в кувшинчики-ловушки, растущими на верхушке корневища. Листья вытянутые, узкие снизу и немного расширяющиеся кверху и часть листа образует крышку. Внутри листьев находиться пищеварительная жидкость, с помощью которой растение переваривает добычу. Добыча привлекается сладковатым нектаром, который вырабатывают листья-ловушки. В отличии от других растений-хищников у саррацении при попадании насекомого внутрь крышка не захлопывается, жертва просто тонет в скопившейся жидкости, постепенно перевариваясь. Цветки одиночные, на длинном цветоносе, диаметром до 10 см, в зависимости от вида их окраска может быть красной, фиолетовой, пурпурной или желтоватой.",
                            Price = 25,
                            PageDescription = "Товар - Саррацения Алата (Alata)",
                            PageKeywords = "Товар, Саррацения Алата, алата, саррацения, Alata"
                        }
                    }
                },
                new Product()
                {
                    Category = pnCategory,
                    ProductImageFilename = "pn-weser.jpg",
                    ModifiedDate = DateTime.UtcNow,
                    Provider = provider,
                    VendorCode = "PN000",
                    Stock = null,
                    StockId = null,
                    ProductParameters = new List<ProductParameter>()
                    {
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = s,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 0
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 0
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = m,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 2
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 4
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = l,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 3
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 6
                                }
                            }
                        }
                    },
                    ProductImages = new List<ProductImage>()
                    {
                        new ProductImage()
                        {
                            Filename = "pn-weser-1.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "pn-weser-2.jpg"
                        }
                    },
                    ProductTranslates = new List<ProductTranslate>()
                    {
                        new ProductTranslate()
                        {
                            Language = english,
                            ProductName = "Pinguicula 'Weser'",
                            ProductDescription = "Pinguícula is a genus of perennial insect-eating plants of the family Bubylata (Lentibulariaceae). Leaves form a rosette. The upper side of the leaf is covered with numerous glands: some of them secrete sugary mucus, which is a trap for small insects; other glands generate enzymes that aid in the digestion of food. The movements of the insects that come across lead to the sheet slowly curling, and the mucus dissolves the proteins of the victim’s body. Flowers solitary, on long peduncles. Possible color: purple, blue, pink, rarely white.",
                            Price = 7.5M,
                            PageDescription = "Product - Pinguicula 'Weser'",
                            PageKeywords = "Produc, Pinguicula Weser, Pinguicula, Weser"
                        },
                        new ProductTranslate()
                        {
                            Language = russion,
                            ProductName = "Жирянка Весер (Weser)",
                            ProductDescription = "Жиря́нка (лат. Pinguícula) — род многолетних насекомоядных растений семейства Пузырчатковые (Lentibulariaceae). Листья образуют прикорневую розетку. Верхняя сторона листа покрыта многочисленными желёзками: одни из них выделяют сахаристую слизь, являющуюся ловушкой для мелких насекомых; другие желёзки генерируют ферменты, способствующие перевариванию пищи. Движения попавшихся насекомых приводят к медленному скручиванию листа, а слизь растворяет белки тела жертвы. Цветки одиночные, на длинных цветоносах. Возможный цвет: фиолетовый, голубой, розовый, редко белый.",
                            Price = 15,
                            PageDescription = "Товар - Жирянка Весер (Weser)",
                            PageKeywords = "Товар, Жирянка Весер (Weser), Жирянка, Весер, Weser"
                        }
                    }
                },
                new Product()
                {
                    Category = utCategory,
                    ProductImageFilename = "ut-vulgaris.jpg",
                    ModifiedDate = DateTime.UtcNow,
                    Provider = provider,
                    VendorCode = "UT000",
                    Stock = null,
                    StockId = null,
                    ProductParameters = new List<ProductParameter>()
                    {
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = s,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 0
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 0
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = m,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 1
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 2
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = l,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 2
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 4
                                }
                            }
                        }
                    },
                    ProductImages = new List<ProductImage>()
                    {
                        new ProductImage()
                        {
                            Filename = "ut-vulgaris-1.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "ut-vulgaris-2.jpg"
                        }
                    },
                    ProductTranslates = new List<ProductTranslate>()
                    {
                        new ProductTranslate()
                        {
                            Language = english,
                            ProductName = "Utricularia 'Vulgaris'",
                            ProductDescription = "In the wild, leaves of utricularia can grow up to one and a half meters long. When grown in pots of course this size, the leaves are difficult to grow, but in any case it is this variety that always grows much larger than the rest. Utricularia flower usually in the warm period of the year beautiful lilac-yellow flowers. Usually bloom long. This pemphigus grows quite quickly. It is best to grow in a pot with a lot of not very small holes on the sides. In these holes the plants will release their roots with bubble traps. In an adult plant, bubbles on the roots are clearly visible. Growing pemphigus should pay special attention to the level of water in the pan. It should be as much as possible so that the roots are always in the water. For planting, you can use a substrate for predatory plants (based on sour peat), and sphagnum with the addition of perlite is also very well suited. Utricularia love bright sunshine. In winter, you need to finish the plant. Aquarium lighting is very good. Utricularia - very unpretentious to the temperature regime. It tolerates heat well, but feels good in a cool place. The main thing is not to freeze. She does not need a rest period. Watering with distilled water.",
                            Price = 5M,
                            PageDescription = "Product - Utricularia 'Vulgaris'",
                            PageKeywords = "Product, Utricularia Vulgaris, Utricularia, Vulgaris"
                        },
                        new ProductTranslate()
                        {
                            Language = russion,
                            ProductName = "Пузырчатка",
                            ProductDescription = "В дикой природе листья пузырчатки могут расти до полутора метров длиной. При выращивании в горшках конечно таких размеров листья сложно вырастить, но в любом случае именно этот сорт всегда вырастает значительно крупнее чем остальные. Цветет Пузырчатка обычно в теплый период года красивыми сиренево-желтыми цветами. Обычно цветение продолжительное. Растет эта пузырчатка довольно быстро. Лучше всего выращивать в горшочке с множеством не очень мелких отверстий по бокам. В эти отверстия растения выпустит свои корни с пузырями-ловушками. У взрослого растения хорошо видны пузыри на корнях. Выращивая пузырчатки нужно уделить особое внимание уровню воды в поддоне. Её должно быть максимально много, чтоб корни всегда находились в воде. Для посадки растения можно использовать субстрат для хищных растений (на основе кислого торфа), а так же очень хорошо подходит сфагнум с добавлением перлита. Пузырчатки любят яркое солнечное освещение. В зимнее время года нужно досвечивать растение. Очень хорошо подойдет аквариумное освещение. Пузырчатка - очень неприхотлива к температурному режиму. Хорошо переносит жару, но в прохладе хорошо себя чувствует. Главное не заморозить. Период покоя ей не нужен. Полив дистиллированной водой.",
                            Price = 10,
                            PageDescription = "Товар - Пузырчатка",
                            PageKeywords = "Товар, пузырчатка"
                        }
                    }
                },
                new Product()
                {
                    Category = dcCategory,
                    ProductImageFilename = "dc.jpg",
                    ModifiedDate = DateTime.UtcNow,
                    Provider = provider,
                    VendorCode = "DC000",
                    Stock = null,
                    StockId = null,
                    ProductParameters = new List<ProductParameter>()
                    {
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = s,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 0
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 0
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = m,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 5
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 10
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = l,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 10
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 20
                                }
                            }
                        }
                    },
                    ProductImages = new List<ProductImage>()
                    {
                        new ProductImage()
                        {
                            Filename = "dc-1.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "dc-2.jpg"
                        }
                    },
                    ProductTranslates = new List<ProductTranslate>()
                    {
                        new ProductTranslate()
                        {
                            Language = english,
                            ProductName = "Darlingtonia Californica",
                            ProductDescription = "Darlingtonia is a genus of insectivorous plants of the Sarrasenie family. The only representative of the genus - Darlingtonia Californian, found in the marshes in the north of California and in Oregon. The genus is named after the American doctor and botanist William Darlington. Very rare plant. In our country, and in Europe, to buy this plant is quite difficult. Snare traps emit a sharp odor that attracts insects. They get inside and can no longer get out. Insects are digested in the digestive juices of the plant, which thus receives additional nutrients. Darlingtonia is a perennial carnivorous plant native to Northern California and Southern Oregon USA. In nature, darlingtonia can be found in mountainous areas in the dammed meadows, in the forest shadows or on the banks of cold mountain rivers. The most favorable condition for the life of this unusual plant is the presence of a number of cold running water. Scientists have recognized this predatory plant as unique in its kind. Darlingtonia Californian - the only member of the Sarrasenie family, the Darlingtonia family. It is often called “cobra” because of tubular leaves, which resemble a cobra with a bloated hood, and small leafy appendages of yellow or reddish-green color, like a forked snake tongue, give even more similarity to this animal. Tubular leaves, reaching up to 100 cm in height, are swollen at the top into a jar with slippery inner walls and a small hole at the bottom - this is a trap-labyrinth for insects. Transparent spots-windows cover the whole leaf, thanks to which the victims in the trap lose their orientation to the real way out and become food for the plant. Darlingtonia blooms in spring, releasing beautiful flowers from yellow to purple-brown on single stems. Interestingly, scientists have so far not been able to figure out which insects pollinate darlingtonia flowers.",
                            Price = 40M,
                            PageDescription = "Product - Darlingtonia Californica",
                            PageKeywords = "Product - Darlingtonia Californica"
                        },
                        new ProductTranslate()
                        {
                            Language = russion,
                            ProductName = "Дарлингтония Калифорнийская",
                            ProductDescription = "Дарлингтония — род насекомоядных растений семейства Саррацениевые. Единственный представитель рода — Дарлингтония калифорнийская, встречающаяся на болотах на севере Калифорнии и в Орегоне. Род назван в честь американского врача и ботаника Уильяма Дарлингтона. Очень редкое растение. В нашей стране, да и в Европе, купить это растение довольно сложно. Ловушки-накопители выделяют резкий запах, который привлекает насекомых. Они попадают внутрь и больше не могут выбраться. Насекомые перевариваются в пищеварительных соках растения, которое таким образом получает дополнительные питательные вещества. Дарлингтония – это многолетнее плотоядное растение родом из Северной Калифорнии и Южного Орегона США. В природе дарлингтонию можно встретить в горной местности на запруженных лугах, в лесной тени или на берегах холодных горных рек. Самым благоприятным условием для жизни этого необычного растения является наличие рядом холодной проточной воды. Ученые признали это хищное растение уникальным в своем роде. Дарлингтония Калифорнийская – единственный представитель семейства Саррацениевые, рода Дарлингтония. Часто её называют «коброй» из-за трубчатых листьев, своей формой напоминающих кобру с раздутым капюшоном, а мелкие листовые придатки желтого или красновато-зеленого цвета, похожие на раздвоенный змеиный язык, придают еще больше сходства с этим животным. Трубчатые листья, достигающие до 100 см в высоту, на верхушке раздуты в кувшин со скользкими внутренними стенками и маленьким отверстием снизу - это ловушка-лабиринт для насекомых. Весь лист покрывают прозрачные пятна-окошки, благодаря которым жертвы в ловушке теряют ориентацию на настоящий выход и становятся пищей для растения. Цветет дарлингтония весной, выпуская красивые цветы от желтого до пурпурно-коричневого цвета на одиночных стеблях. Интересно, что ученым так до сих пор не удалось выяснить, какие насекомые опыляют цветы дарлингтонии.",
                            Price = 80,
                            PageDescription = "Товар - Дарлингтония Калифорнийская",
                            PageKeywords = "Товар, Дарлингтония Калифорнийская, Дарлингтония, Калифорнийская"
                        }
                    }
                },
                new Product()
                {
                    Category = cfCategory,
                    ProductImageFilename = "cf.jpg",
                    ModifiedDate = DateTime.UtcNow,
                    Provider = provider,
                    VendorCode = "CF000",
                    Stock = null,
                    StockId = null,
                    ProductParameters = new List<ProductParameter>()
                    {
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = s,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 0
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 0
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = m,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 5
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 10
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = l,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 10
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 20
                                }
                            }
                        }
                    },
                    ProductImages = new List<ProductImage>()
                    {
                        new ProductImage()
                        {
                            Filename = "cf-0.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "cf-1.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "cf-2.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "cf-3.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "cf-4.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "cf-5.jpg"
                        },
                        new ProductImage()
                        {
                            Filename = "cf-6.jpg"
                        }
                    },
                    ProductTranslates = new List<ProductTranslate>()
                    {
                        new ProductTranslate()
                        {
                            Language = english,
                            ProductName = "Cephalotus Follicularis",
                            ProductDescription = "Predatory plant Cephalotus is very capricious in the care. He likes high humidity, but does not like waterlogging and drying of the soil. Does not like heat. He likes the difference of day and night temperatures: in the evening +12 + 15°С, in the daytime +20 + 25°С. Suitable for experienced predator.",
                            Price = 25M,
                            PageDescription = "Product - Cephalotus Follicularis",
                            PageKeywords = "Product, Cephalotus Follicularis, Cephalotus, Follicularis"
                        },
                        new ProductTranslate()
                        {
                            Language = russion,
                            ProductName = "Цефалотус",
                            ProductDescription = "Хищное растение Цефалотус очень прихотливое в уходе. Любит повышенную влажность воздуха, но не любит переувлажнение и пересыхание почвы. Не любит жару. Любит перепад дневных и ночных температур: вечером +12 +15°С, днем +20 +25°С. Подойдет для опытных хищниководов.",
                            Price = 50,
                            PageDescription = "Товар - Цефалотус",
                            PageKeywords = "Товар, Цефалотус"
                        }
                    }
                },
                new Product()
                {
                    Category = seedCategory,
                    ProductImageFilename = "dm-seed.jpg",
                    ModifiedDate = DateTime.UtcNow,
                    Provider = provider,
                    VendorCode = "SEED0",
                    Stock = null,
                    StockId = null,
                    ProductParameters = new List<ProductParameter>()
                    {
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = seedSmall,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 0
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 0
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = seedMedium,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 1
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 2
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = seedLarge,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 2
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 4
                                }
                            }
                        }
                    },
                    ProductImages = new List<ProductImage>()
                    {
                        new ProductImage()
                        {
                            Filename = "dm-seed-1.jpg"
                        }
                    },
                    ProductTranslates = new List<ProductTranslate>()
                    {
                        new ProductTranslate()
                        {
                            Language = english,
                            ProductName = "Dionaea Muscipula seeds",
                            ProductDescription = "Seeds are black, glossy, small.",
                            Price = 2.5M,
                            PageDescription = "Product - Dionaea Muscipula seeds",
                            PageKeywords = "Product, Dionaea Muscipula seeds, Dionaea Muscipula, seeds"
                        },
                        new ProductTranslate()
                        {
                            Language = russion,
                            ProductName = "Семена венериной мухоловки",
                            ProductDescription = "Семена черного цвета, глянцевые, мелкие.",
                            Price = 5,
                            PageDescription = "Товар - Семена венериной мухоловки",
                            PageKeywords = "Товар, Семена венериной мухоловки, Семена, венериной мухоловки"
                        }
                    }
                },
                new Product()
                {
                    Category = relatedCategory,
                    ProductImageFilename = "carnivorous-plant-soil-mix.jpg",
                    ModifiedDate = DateTime.UtcNow,
                    Provider = provider,
                    VendorCode = "RP000",
                    Stock = null,
                    StockId = null,
                    ProductParameters = new List<ProductParameter>()
                    {
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = substratSmall,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 0
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 0
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = substratMedium,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 1
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 2
                                }
                            }
                        },
                        new ProductParameter()
                        {
                            Availability = true,
                            Dimension = substratLarge,
                            ProductParameterTranslates = new List<ProductParameterTranslate>()
                            {
                                new ProductParameterTranslate()
                                {
                                    Language = english,
                                    PriceIncrease = 2
                                },
                                new ProductParameterTranslate()
                                {
                                    Language = russion,
                                    PriceIncrease = 4
                                }
                            }
                        }
                    },
                    ProductImages = new List<ProductImage>()
                    {
                        new ProductImage()
                        {
                            Filename = "carnivorous-plant-soil-mix.jpg"
                        }
                    },
                    ProductTranslates = new List<ProductTranslate>()
                    {
                        new ProductTranslate()
                        {
                            Language = english,
                            ProductName = "Carnivorous plant soil mix",
                            ProductDescription = "Special substrate for most predatory plants.",
                            Price = 1M,
                            PageDescription = "Product - Carnivorous plant soil mix",
                            PageKeywords = "Product, Carnivorous plant soil mix, Carnivorous plant soil, mix"
                        },
                        new ProductTranslate()
                        {
                            Language = russion,
                            ProductName = "Субстрат для хищных растений",
                            ProductDescription = "Специальный субстрат для большинства хищных растений.",
                            Price = 2,
                            PageDescription = "Товар - Субстрат для хищных растений",
                            PageKeywords = "Товар, Субстрат для хищных растений, Субстрат, хищных растений"
                        }
                    }
                }
            };

            context.Products.AddRange(products);

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
