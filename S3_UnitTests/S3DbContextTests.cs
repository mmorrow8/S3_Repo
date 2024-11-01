using Microsoft.EntityFrameworkCore;
using S3_Domain;
using S3_EF;
using Xunit;
using Microsoft.EntityFrameworkCore.InMemory;

namespace S3_UnitTests
{
    public class S3DbContextTests
    {
        private S3DbContext CreateInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<S3DbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())  // Unique database for each test
                .Options;

            var context = new S3DbContext(options);

            // Seed test data here
            context.USStates.AddRange(context.AddStateData());
            context.DocumentTypes.AddRange(context.AddDocumentTypeData());
            context.USStateDocumentTypes.AddRange(context.AddUSStateDocumentTypeData());

            context.SaveChanges();

            return context;
        }

        [Fact]
        public void Test_StateRetrieval()
        {
            // Arrange
            var context = CreateInMemoryContext();

            // Act
            var states = context.USStates.ToList();

            // Assert
            Assert.Equal(51, states.Count);
        }

        [Fact]
        public void Test_AddState()
        {
            var context = CreateInMemoryContext();

            var state = new USState { StateId = Guid.NewGuid(), StateName = "Test State", StateCode = "TS" };
            context.USStates.Add(state);
            context.SaveChanges();

            var states = context.USStates.ToList();
            var savedState = states.FirstOrDefault(s => s.StateName == "Test State");
            Assert.NotNull(savedState);
            Assert.Equal("TS", savedState.StateCode);
            Assert.Equal(52, states.Count);
        }


        //the purpose of this unit test is to test whether two entries for
        //the same state, document type, effective dates, and output format can be added
        //fix this unit test (may require update of EF model
        [Fact]
        public void Test_AddDuplicateStateDocumentType_ShouldThrowDbUpdateException()
        {
            var context = CreateInMemoryContext();

            var usStateId = Guid.NewGuid();
            var documentTypeId = Guid.NewGuid();

            var entity = new USStateDocumentType { USStateDocumentTypeId = Guid.NewGuid(), USStateId = usStateId, DocumentTypeId = documentTypeId };
            context.USStateDocumentTypes.Add(entity);
            context.SaveChanges();

            // Act
            var duplicateEntity = new USStateDocumentType { USStateDocumentTypeId = Guid.NewGuid(), USStateId = usStateId, DocumentTypeId = documentTypeId };
            context.USStateDocumentTypes.Add(entity);

            // Assert
            Assert.Throws<DbUpdateException>(() => context.SaveChanges());
        }

    }
}