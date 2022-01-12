using System;

namespace LinnworksAPI
{
    public class ApiObjectManager
    {
        private ApiContext apiContext;
        private AuthController auth;
        private CustomerController customer;
        private DashboardsController dashboards;
        private EmailController email;
        private ImportExportController importexport;
        private InventoryController inventory;
        private ListingsController listings;
        private LocationsController locations;
        private MacroController macro;
        private OpenOrdersController openorders;
        private OrderPrintStatusController orderprintstatus;
        private OrdersController orders;
        private OrderWorkflowController orderworkflow;
        private PickingController picking;
        private PostalServicesController postalservices;
        private PostSaleController postsale;
        private PrintServiceController printservice;
        private ProcessedOrdersController processedorders;
        private PurchaseOrderController purchaseorder;
        private ReturnsRefundsController returnsrefunds;
        private RulesEngineController rulesengine;
        private SettingsController settings;
        private ShippingServiceController shippingservice;
        private ShipStationController shipstation;
        private StockController stock;
        private WarehouseTransferController warehousetransfer;
        private WmsController wms;


        public ApiObjectManager(ApiContext apiContext)
        {                       
            this.apiContext = apiContext;
        }
        
        public Guid GetSessionId()
        {
            return apiContext.SessionId;
        }
        public AuthController Auth
        {
            get
            {
                return auth ?? (auth = new AuthController(apiContext));
            }
        }

        public CustomerController Customer
        {
            get
            {
                return customer ?? (customer = new CustomerController(apiContext));
            }
        }

        public DashboardsController Dashboards
        {
            get
            {
                return dashboards ?? (dashboards = new DashboardsController(apiContext));
            }
        }

        public EmailController Email
        {
            get
            {
                return email ?? (email = new EmailController(apiContext));
            }
        }

        public ImportExportController ImportExport
        {
            get
            {
                return importexport ?? (importexport = new ImportExportController(apiContext));
            }
        }

        public InventoryController Inventory
        {
            get
            {
                return inventory ?? (inventory = new InventoryController(apiContext));
            }
        }

        public ListingsController Listings
        {
            get
            {
                return listings ?? (listings = new ListingsController(apiContext));
            }
        }

        public LocationsController Locations
        {
            get
            {
                return locations ?? (locations = new LocationsController(apiContext));
            }
        }

        public MacroController Macro
        {
            get
            {
                return macro ?? (macro = new MacroController(apiContext));
            }
        }

        public OpenOrdersController OpenOrders
        {
            get
            {
                return openorders ?? (openorders = new OpenOrdersController(apiContext));
            }
        }

        public OrderPrintStatusController OrderPrintStatus
        {
            get
            {
                return orderprintstatus ?? (orderprintstatus = new OrderPrintStatusController(apiContext));
            }
        }

        public OrdersController Orders
        {
            get
            {
                return orders ?? (orders = new OrdersController(apiContext));
            }
        }

        public OrderWorkflowController OrderWorkflow
        {
            get
            {
                return orderworkflow ?? (orderworkflow = new OrderWorkflowController(apiContext));
            }
        }

        public PickingController Picking
        {
            get
            {
                return picking ?? (picking = new PickingController(apiContext));
            }
        }

        public PostalServicesController PostalServices
        {
            get
            {
                return postalservices ?? (postalservices = new PostalServicesController(apiContext));
            }
        }

        public PostSaleController PostSale
        {
            get
            {
                return postsale ?? (postsale = new PostSaleController(apiContext));
            }
        }

        public PrintServiceController PrintService
        {
            get
            {
                return printservice ?? (printservice = new PrintServiceController(apiContext));
            }
        }

        public ProcessedOrdersController ProcessedOrders
        {
            get
            {
                return processedorders ?? (processedorders = new ProcessedOrdersController(apiContext));
            }
        }

        public PurchaseOrderController PurchaseOrder
        {
            get
            {
                return purchaseorder ?? (purchaseorder = new PurchaseOrderController(apiContext));
            }
        }

        public ReturnsRefundsController ReturnsRefunds
        {
            get
            {
                return returnsrefunds ?? (returnsrefunds = new ReturnsRefundsController(apiContext));
            }
        }

        public RulesEngineController RulesEngine
        {
            get
            {
                return rulesengine ?? (rulesengine = new RulesEngineController(apiContext));
            }
        }

        public SettingsController Settings
        {
            get
            {
                return settings ?? (settings = new SettingsController(apiContext));
            }
        }

        public ShippingServiceController ShippingService
        {
            get
            {
                return shippingservice ?? (shippingservice = new ShippingServiceController(apiContext));
            }
        }

        public ShipStationController ShipStation
        {
            get
            {
                return shipstation ?? (shipstation = new ShipStationController(apiContext));
            }
        }

        public StockController Stock
        {
            get
            {
                return stock ?? (stock = new StockController(apiContext));
            }
        }

        public WarehouseTransferController WarehouseTransfer
        {
            get
            {
                return warehousetransfer ?? (warehousetransfer = new WarehouseTransferController(apiContext));
            }
        }

        public WmsController Wms
        {
            get
            {
                return wms ?? (wms = new WmsController(apiContext));
            }
        }

 
    }
}