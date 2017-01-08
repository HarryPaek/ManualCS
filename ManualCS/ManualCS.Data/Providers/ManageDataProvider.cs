using ManualCS.Data.Abstracts;
using ManualCS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualCS.Data.Providers
{
    public class ManageDataProvider : IManageDataProvider
    {
        public IEnumerable<ManageCategory> GetList()
        {
            return GetTestData();
        }

        private IEnumerable<ManageCategory> GetTestData()
        {
            var data = new List<ManageCategory>();

            data.Add(GetServerData());
            data.Add(GetPrinterData());
            data.Add(GetNetworkData());
            data.Add(GetScannerData());

            return data;
        }

        private ManageCategory GetServerData()
        {
            var server = new ManageCategory("Server");
            server.Items.Add(new ManageItem
            {
                HeaderText = "매뉴얼",
                Name = "Manual",
                FileName = "Server.Manual.pdf",
                IconIndex = 1
            });
            server.Items.Add(new ManageItem
            {
                HeaderText = "고장 신고",
                Name = "Incident",
                FileName = "Server.Incident.pdf",
                IconIndex = 2
            });

            server.Items.Add(new ManageItem
            {
                HeaderText = "조치 이력",
                Name = "History",
                FileName = "Server.History.pdf",
                IconIndex = 3
            });

            return server;
        }

        private ManageCategory GetPrinterData()
        {
            var printer = new ManageCategory("Printer");
            printer.Items.Add(new ManageItem
            {
                HeaderText = "매뉴얼",
                Name = "Manual",
                FileName = "Printer.Manual.pdf",
                IconIndex = 11
            });

            printer.Items.Add(new ManageItem
            {
                HeaderText = "소모품 요청",
                Name = "InkRequest",
                FileName = "Printer.InkRequest.pdf",
                IconIndex = 12
            });

            printer.Items.Add(new ManageItem
            {
                HeaderText = "고장신고",
                Name = "Incident",
                FileName = "Printer.Incident.pdf",
                IconIndex = 13
            });

            printer.Items.Add(new ManageItem
            {
                HeaderText = "조치이력",
                Name = "History",
                FileName = "Printer.History.pdf",
                IconIndex = 14
            });

            return printer;
        }

        private ManageCategory GetNetworkData()
        {
            var network = new ManageCategory("Network");
            network.Items.Add(new ManageItem
            {
                HeaderText = "매뉴얼",
                Name = "Manual",
                FileName = "Network.Manual.pdf",
                IconIndex = 21
            });

            network.Items.Add(new ManageItem
            {
                HeaderText = "IP 요청",
                Name = "IPRequest",
                FileName = "Network.IPRequest.pdf",
                IconIndex = 22
            });

            network.Items.Add(new ManageItem
            {
                HeaderText = "바이러스 신고",
                Name = "VirusCall",
                FileName = "Network.VirusCall.pdf",
                IconIndex = 23
            });

            network.Items.Add(new ManageItem
            {
                HeaderText = "고장신고",
                Name = "Incident",
                FileName = "Network.Incident.pdf",
                IconIndex = 24
            });

            network.Items.Add(new ManageItem
            {
                HeaderText = "조치이력",
                Name = "History",
                FileName = "Network.History.pdf",
                IconIndex = 25
            });

            return network;
        }

        private ManageCategory GetScannerData()
        {
            var scanner = new ManageCategory("Scanner");
            scanner.Items.Add(new ManageItem
            {
                HeaderText = "매뉴얼",
                Name = "Manual",
                FileName = "Scanner.Manual.pdf",
                IconIndex = 31
            });

            scanner.Items.Add(new ManageItem
            {
                HeaderText = "교환/설치 요청",
                Name = "ItemRequest",
                FileName = "Scanner.ItemRequest.pdf",
                IconIndex = 32
            });

            scanner.Items.Add(new ManageItem
            {
                HeaderText = "소모품 요청",
                Name = "MRORequest",
                FileName = "Scanner.MRORequest.pdf",
                IconIndex = 33
            });

            scanner.Items.Add(new ManageItem
            {
                HeaderText = "고장신고",
                Name = "Incident",
                FileName = "Scanner.Incident.pdf",
                IconIndex = 34
            });

            scanner.Items.Add(new ManageItem
            {
                HeaderText = "조치이력",
                Name = "History",
                FileName = "Scanner.History.pdf",
                IconIndex = 35
            });

            return scanner;
        }

    }
}
