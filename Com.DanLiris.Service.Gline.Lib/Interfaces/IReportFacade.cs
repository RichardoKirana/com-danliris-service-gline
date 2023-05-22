﻿using Com.DanLiris.Service.Gline.Lib.ViewModels.ReportViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Com.DanLiris.Service.Gline.Lib.Interfaces
{
    public interface IReportFacade
    {
        Tuple<List<RoDoneReportViewModel>, int> GetRoDoneReport(string unit, int line, DateTimeOffset? dateFrom, DateTimeOffset? dateTo);
        MemoryStream GetRoDoneExcel(string unit, int line, DateTimeOffset dateFrom, DateTimeOffset dateTo);
        Tuple<List<RoHourlyReportViewModel>, int> GetRoHourlyReport(string unit, int line, DateTimeOffset? dateFrom, DateTimeOffset? dateTo);
        MemoryStream GetRoHourlyExcel(string unit, int line, DateTimeOffset dateFrom, DateTimeOffset dateTo);
        Tuple<List<RoDetailOptReportViewModel>, int> GetRoDetailOptReport(string ro, string unit, int line, DateTimeOffset? date);
        MemoryStream GetRoDetailOptExcel(string ro, string unit, int line, DateTimeOffset? date);
        Tuple<List<RoOperatorHourlyWebReportViewModel>, int> GetRoOperatorHourlyWebReport(string area, int line, string proses, DateTimeOffset? dateFrom, DateTimeOffset? dateTo);
        MemoryStream GetRoOperatorHourlyWebExcel(string area, int line, string proses, DateTimeOffset? dateFrom, DateTimeOffset? dateTo);
        Tuple<List<RoOperatorHourlyPerDayReportViewModel>, int> GetRoOperatorHourlyPerDayReport(string unit, int line, string npk);
        Tuple<List<RoOperatorHourlyPerDayPerHourReportViewModel>, int> GetRoOperatorHourlyPerDayPerHourReport(string unit, int line, string npk, DateTimeOffset? date);
        Tuple<List<RoOperatorHourlyPerDayPerHourPerRoReportViewModel>, int> GetRoOperatorHourlyPerDayPerHourPerRoReport(string unit, int line, string npk, DateTimeOffset? date, string hour);
        RoOperatorHourlyDataReportViewModel GetRoOperatorHourlyReport(string unit, int line, string npk, DateTimeOffset? date, string hour, string ro);
        MemoryStream GetRoOperatorHourlyExcel(string unit, int line, DateTimeOffset? date, string ro);
    }
}
