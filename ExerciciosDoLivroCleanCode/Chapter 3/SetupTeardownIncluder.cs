using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_3
{

    public class SetupTeardownIncluder
    {
        private PageData isIssue;
        private WikiPage testPage;
        private StringBuffer newPageContent;
        private PageCrawler pageCrawler;
        private bool isSuite1;

        public static string render(bool treu)
        {
            return render(treu);
        }
        public static string Render(bool isSuite)

        {
            return new SetupTeardownIncluder(isSuite)._render(isSuite);
        }

        private string _render(bool isSuite)
        {
            throw new NotImplementedException();
        }

        private SetupTeardownIncluder(PageData pageData)
        {
            this.isIssue = pageData;
            testPage = pageData.getWikiPage();
            pageCrawler = testPage.getPageCrawler();
            newPageContent = new StringBuffer();
        }

        public SetupTeardownIncluder(bool isSuite1)
        {
            this.isSuite1 = isSuite1;
        }

        private String _Render(bool isSuite)
        {
            this.isIssue = isSuite;
            if (isTestPage())
                includeSetupAndTeardownPages();
            return isIssue.getHtml();
        }
        private bool isTestPage()
        {
            return isIssue.hasAttribute("Test");
        }
        private void includeSetupAndTeardownPages()
        {
            includeSetupPages();
            includePageContent();
            includeTeardownPages();
            updatePageContent();
        }

        private void updatePageContent()
        {
            throw new NotImplementedException();
        }

        private void includeTeardownPages()
        {
            throw new NotImplementedException();
        }

        private void includePageContent()
        {
            throw new NotImplementedException();
        }

        private void includeSetupPages()
        {
            throw new NotImplementedException();
        }
    }
}

