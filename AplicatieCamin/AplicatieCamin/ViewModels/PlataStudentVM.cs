using AplicatieCamin.Models.BusinessLogicLayer;
using AplicatieCamin.Models.EntityLayer;
using AplicatieCamin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Windows.Input;
using AplicatieCamin.ViewModels.Commands;
using iText.Kernel.Colors;

namespace AplicatieCamin.ViewModels
{
    class PlataStudentVM : BasePropertyChanged
    {
        PlataBLL plataBLL;
        ObservableCollection<Plata> taxe;
        public PlataStudentVM()
        {
            plataBLL = new PlataBLL();
            taxe = new ObservableCollection<Plata>(plataBLL.ToatePlatileUnuiStudent(TaxeStudent.StudentCurent));
            TaxePlatite = new ObservableCollection<Plata>();
            TaxeNeplatite = new ObservableCollection<Plata>();
            Nume = TaxeStudent.StudentCurent.Nume;
            Prenume = TaxeStudent.StudentCurent.Prenume;
            foreach (var plata in taxe)
            {
                if(plata.Platita)
                {
                    TaxePlatite.Add(plata);
                }
                else
                {
                    TaxeNeplatite.Add(plata);
                }
            }
            
        }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        Plata taxaSelectata;
        public Plata TaxaSelectata
        {
            get
            {
                return taxaSelectata;
            }
            set
            {
                taxaSelectata = value;
                if (taxaSelectata != null)
                {
                    PlataSelectata = true;
                }
                NotifyPropertyChanged("TaxaSelectata");
            }
        }

        ObservableCollection<Plata> taxePlatite;
        public ObservableCollection<Plata> TaxePlatite
        {
            get
            {
                return taxePlatite;
            }
            set
            {
                taxePlatite = value;
                NotifyPropertyChanged("TaxePlatite");
            }
        }

        ObservableCollection<Plata> taxeNeplatite;
        public ObservableCollection<Plata> TaxeNeplatite
        {
            get
            {
                return taxeNeplatite;
            }
            set
            {
                taxeNeplatite = value;
                
                NotifyPropertyChanged("TaxeNeplatite");
            }
        }

        bool plataSelectata;
        public bool PlataSelectata
        {
            get
            {
                return plataSelectata;
            }
            set
            {
                plataSelectata = value;
                NotifyPropertyChanged("PlataSelectata");
            }
        }

        public void PlatesteTaxa(object o)
        {

            TaxaSelectata.Platita = true;
            plataBLL.ModificaPlata(TaxaSelectata);

            PdfWriter writer = new PdfWriter("E:\\Facultate\\mvp\\Camin\\chitante\\chitanta.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph("Chitanta")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);

            document.Add(header);

            Paragraph subheader = new Paragraph("Caminul: "+ TaxeStudent.StudentCurent.Camin).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15);
            document.Add(subheader);

            Table table = new Table(7, false);
            Cell cell11 = new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Nume"));
            Cell cell12 = new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Prenume"));
            Cell cell13 = new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Facultate"));
            Cell cell14 = new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Camin"));
            Cell cell15 = new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Camera"));
            Cell cell16 = new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Luna"));
            Cell cell17 = new Cell(1, 1)
               .SetBackgroundColor(ColorConstants.GRAY)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Suma"));

            Cell cell21 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph(TaxeStudent.StudentCurent.Nume));
            Cell cell22 = new Cell(1, 1)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph(TaxeStudent.StudentCurent.Prenume));
            Cell cell23 = new Cell(1, 1)
              .SetTextAlignment(TextAlignment.CENTER)
              .Add(new Paragraph(TaxeStudent.StudentCurent.Facultate));
            Cell cell24 = new Cell(1, 1)
              .SetTextAlignment(TextAlignment.CENTER)
              .Add(new Paragraph(TaxeStudent.StudentCurent.Camin.ToString()));
            Cell cell25 = new Cell(1, 1)
              .SetTextAlignment(TextAlignment.CENTER)
              .Add(new Paragraph(TaxeStudent.StudentCurent.Camera.ToString()));
            Cell cell26 = new Cell(1, 1)
              .SetTextAlignment(TextAlignment.CENTER)
              .Add(new Paragraph(TaxaSelectata.Luna));
            Cell cell27 = new Cell(1, 1)
              .SetTextAlignment(TextAlignment.CENTER)
              .Add(new Paragraph(TaxaSelectata.Suma.ToString()));


            

            table.AddCell(cell11);
            table.AddCell(cell12);
            table.AddCell(cell13);
            table.AddCell(cell14);
            table.AddCell(cell15);
            table.AddCell(cell16);
            table.AddCell(cell17);

            table.AddCell(cell21);
            table.AddCell(cell22);
            table.AddCell(cell23);
            table.AddCell(cell24);
            table.AddCell(cell25);
            table.AddCell(cell26);
            table.AddCell(cell27);

            document.Add(table);
            document.Close();

            TaxaSelectata.Platita = true;
            plataBLL.ModificaPlata(TaxaSelectata);

            taxe = new ObservableCollection<Plata>(plataBLL.ToatePlatileUnuiStudent(TaxeStudent.StudentCurent));
            TaxePlatite = new ObservableCollection<Plata>();
            TaxeNeplatite = new ObservableCollection<Plata>();
            Nume = TaxeStudent.StudentCurent.Nume;
            Prenume = TaxeStudent.StudentCurent.Prenume;
            foreach (var plata in taxe)
            {
                if (plata.Platita)
                {
                    TaxePlatite.Add(plata);
                }
                else
                {
                    TaxeNeplatite.Add(plata);
                }
            }
        }

        private ICommand plateste;
        public ICommand Plateste
        {
            get
            {
                if (plateste == null)
                {
                    plateste = new RelayCommand(PlatesteTaxa);
                }
                return plateste;
            }
        }
    }
}
