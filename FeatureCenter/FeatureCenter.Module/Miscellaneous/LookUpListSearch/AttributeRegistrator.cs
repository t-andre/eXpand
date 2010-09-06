﻿using System;
using System.Collections.Generic;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using Xpand.ExpressApp.AdditionalViewControlsProvider.Logic;
using Xpand.ExpressApp.Attributes;

namespace FeatureCenter.Module.Miscellaneous.LookUpListSearch
{
    public class AttributeRegistrator:Xpand.ExpressApp.Core.AttributeRegistrator
    {
        private const string LookUpListSearch_LookupListView = "LookUpListSearch_LookupListView";
        private const string LookUpListSearch_DetailView = "LookUpListSearch_DetailView";
        public override IEnumerable<Attribute> GetAttributes(ITypeInfo typesInfo) {
            if (typesInfo.Type == typeof(Customer)) {
               yield return new CloneViewAttribute(CloneViewType.ListView, LookUpListSearch_LookupListView);
            }
            if (typesInfo.Type==typeof(Order)) {
                yield return new AdditionalViewControlsRuleAttribute(Captions.ViewMessage + " " + Captions.HeaderLookUpListSearch, "1=1", "1=1", Captions.ViewMessageLookUpListSearch, Position.Bottom){ViewType = ViewType.DetailView, View = LookUpListSearch_DetailView};
                yield return new AdditionalViewControlsRuleAttribute(Captions.Header + " " + Captions.HeaderLookUpListSearch, "1=1", "1=1", Captions.HeaderLookUpListSearch, Position.Top) { ViewType = ViewType.DetailView, View = LookUpListSearch_DetailView };
                yield return new XpandNavigationItemAttribute(Captions.Miscellaneous + "Lookup List Search", LookUpListSearch_DetailView);
                yield return new CloneViewAttribute(CloneViewType.DetailView, LookUpListSearch_DetailView);
                yield return new DisplayFeatureModelAttribute(LookUpListSearch_DetailView);
            }
        }
    }
}
