using Firma.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Firma.ViewModel
{
    public class MainWindowViewModel:BaseViewModel
    {
        #region Fields
        //Poprzez MainWindowViewModel będziemy sterować kolekcją linków, które będą znajdowały się po lewej stronie okna, oraz kolekcją zakładek, które będą znajdowały się po prawej stronie okna
        //To jest kolekcja linków po lewej stronie
        // private ReadOnlyCollection<CommandViewModel> _Commands; //Każdy link po lewej stronie jest CommandViewModelem
        //Poniższe oznacza zbiór zakładek po prawej stronie
        private ObservableCollection<WorkspaceViewModel> _Workspaces;
        #endregion

        #region ToolBarCommands

        private BaseCommand getCommand(BaseCommand _command, WorkspaceViewModel workspace) // oszczedza powtarzalonśc kodu
        {
            if(_command == null)
            
                _command = new BaseCommand(() => Create(workspace));
            return _command;
            
        }

        //To jest komenda która zostanie podpięta pod przycisk w pasku narzędzi i ta komenda wywoła funkcję Create

        private BaseCommand _WszystkieNaprawyCommand;
        public ICommand WszystkieNaprawyCommand
        {
            get
            {
                return getCommand(_WszystkieNaprawyCommand, new WszystkieNaprawyViewModel());
            }
        }

        private BaseCommand _DodajNapraweCommand;
        public ICommand DodajNapraweCommand
        {
            get
            {
                return getCommand(_DodajNapraweCommand, new NowaNaprawaViewModel());
            }
        }

        private BaseCommand _FakturaCommand;
        public ICommand FakturaCommand
        {
            get
            {
                return getCommand(_FakturaCommand, new FakturaViewModel());
            }
        }

        private BaseCommand _DodajFaktureCommand;
        public ICommand DodajFaktureCommand
        {
            get
            {
                return getCommand(_DodajFaktureCommand, new DodajFaktureViewModel());
            }
        }

        private BaseCommand _CreateAddProduktCommand;
        public ICommand CreateAddProduktCommand
        {
            get
            {
                return getCommand(_CreateAddProduktCommand, new AddProduktViewModel());
            }
        }


        private BaseCommand _CreateProduktCommand;
        public ICommand CreateProduktCommand
        {
            get
            {
                return getCommand(_CreateProduktCommand, new IndeksProduktowViewModel());
            }
        }

        private BaseCommand _CreateTowarCommand;
        public ICommand CreateTowarCommand
        {
            get
            {
                return getCommand(_CreateTowarCommand, new NowyTowarViewModel());
            }
        }

        private BaseCommand _CreateOsobaCommand;
        public ICommand CreateOsobaCommand
        {
            get
            {
                return getCommand(_CreateOsobaCommand, new NowaOsobaViewModel());
            }
        }

        private BaseCommand _CreateFakturaCommand;
        public ICommand CreateFakturaCommand
        {
            get
            {
                return getCommand(_CreateFakturaCommand, new NowaFakturaViewModel());
            }
        }

        private BaseCommand _CreateKontaktCommand;
        public ICommand CreateKontaktCommand
        {
            get
            {
                return getCommand(_CreateKontaktCommand, new NowyKontaktViewModel());
            }
        }


        private BaseCommand _CreateBadaniaLekarskie;

        public ICommand CreateBadaniaLekarskie
        {
            get
            {
                return getCommand(_CreateBadaniaLekarskie, new BadaniaLekarskieViewModel());
            }
        }


        private BaseCommand _CreateKartotekaOsobowa;

        public ICommand CreateKartotekaOsobowa
        {
            get
            {
                return getCommand(_CreateKartotekaOsobowa, new KartotekaOsobowaViewModel());
            }
        }



        private BaseCommand _CreateHistoria;

        public ICommand CreateHistoria
        {
            get
            {
                return getCommand(_CreateHistoria, new HistoriaViewModel());
            }
        }



        private BaseCommand _CreateOdzialy;

        public ICommand CreateOdzialy
        {
            get
            {
                return getCommand(_CreateOdzialy, new OdzialyViewModel());
            }
        }

        private BaseCommand _CreateSzkoleniaOkresowe;

        public ICommand CreateSzkoleniaOkresowe
        {
            get
            {
                return getCommand(_CreateSzkoleniaOkresowe, new SzkoleniaOkresoweViewModel());
            }
        }


        private BaseCommand _CreateWnioskiUrlopowe;

        public ICommand CreateWnioskiUrlopowe
        {
            get
            {
                return getCommand(_CreateWnioskiUrlopowe, new WnioskiUrlopoweViewModel());
            }
        }



        private BaseCommand _CreateNowaOsobaView;

        public ICommand CreateNowaOsobaView
        {
            get
            {
                return getCommand(_CreateNowaOsobaView, new NowaOsobaViewModel());
            }
        }

        #endregion


        #region Commands

        #endregion


        #region Workspaces
        public ObservableCollection<WorkspaceViewModel> Workspaces
        {
            get
            {
                if(_Workspaces==null)
                {
                    _Workspaces = new ObservableCollection<WorkspaceViewModel>();
                    _Workspaces.CollectionChanged += this.OnWorkspacesChanged;
                }
                return _Workspaces;
            }
        }
        private void OnWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null && e.NewItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.NewItems)
                    workspace.RequestClose += this.OnWorkspaceRequestClose;
            if (e.OldItems != null && e.OldItems.Count != 0)
                foreach (WorkspaceViewModel workspace in e.OldItems)
                    workspace.RequestClose -= this.OnWorkspaceRequestClose;
        }
        private void OnWorkspaceRequestClose(object sender, EventArgs e)
        {
            WorkspaceViewModel workspace = sender as WorkspaceViewModel;
            //workspace.Dispos();
            this.Workspaces.Remove(workspace);
        }
        #endregion


        #region PrivateHelpers
        //Zamiast tysiąca funkcji jedna Create
        private void Create(WorkspaceViewModel workspace)
        {
            this.Workspaces.Add(workspace);
            this.SetActiveWorkspace(workspace);
        }
 
        private void SetActiveWorkspace(WorkspaceViewModel workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null) collectionView.MoveCurrentTo(workspace);
        }

        #endregion
    }
}
