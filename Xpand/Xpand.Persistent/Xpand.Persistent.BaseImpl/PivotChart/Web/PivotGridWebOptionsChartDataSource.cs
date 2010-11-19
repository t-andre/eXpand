﻿using DevExpress.Xpo;
using Xpand.Persistent.Base.PivotChart.Web;
using Xpand.Xpo;

namespace Xpand.Persistent.BaseImpl.PivotChart.Web {
    [NonPersistent]
    public class PivotGridWebOptionsChartDataSource : XpandCustomObject, IPivotGridWebOptionsChartDataSource {
        public PivotGridWebOptionsChartDataSource(Session session)
            : base(session) {
        }
    }
}