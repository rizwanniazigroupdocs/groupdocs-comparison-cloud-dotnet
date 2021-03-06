﻿using GroupDocs.Comparison.Cloud.Sdk.Test.Api;
using GroupDocs.Comparison.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;
using System.Collections.Generic;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Comparison.Cloud.Sdk.Test.Image
{
    public class UpdatesImageTests : BaseApiTest
    {
        [Test]
        public void UpdatesImage()
        {
            var options = GetComparisonOptionsUpdates(TestFiles.SourceImage, new List<TestFile> { TestFiles.TargetImage });
            var response = CompareApi.PutChangesDocument(new PutChangesDocumentRequest(options));
            Assert.AreEqual(response.Rel, options.OutputPath);
        }
    }
}
