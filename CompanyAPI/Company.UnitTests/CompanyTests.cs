using AutoFixture.Xunit2;
using Company.UnitTests.Common;
using Company.UnitTests.MockData;
using CompanyAPI.Models.Repositories;
using FakeItEasy;

namespace Company.UnitTests
{
    public class CompanyTests
    {
        [Theory, AutoFakeItEasyData]
        public async Task GetCompanieesAsync_ShouldFetchCompaniesDataSucessfully([Frozen] ICompanyRepository companyRepository)
        {
            // Arrange
            A.CallTo(() => companyRepository.GetAllCompaniesAsync()).Returns(Task.FromResult(CompanyRepositoryMockData.Companies));
            
            // Act
            var result = await companyRepository.GetAllCompaniesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(CompanyRepositoryMockData.Companies, result);
        }

        [Theory, AutoFakeItEasyData]
        public async Task GetCompanyById_ShouldFetchCompanyDataSuccessfully([Frozen] ICompanyRepository companyRepository)
        {
            // Arrange
            int companyId = 101;
            A.CallTo(() => companyRepository.GetCompanyByIdAsync(companyId)).Returns(Task.FromResult(CompanyRepositoryMockData.Company));

            // Act
            var result = await companyRepository.GetCompanyByIdAsync(companyId);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(CompanyRepositoryMockData.Company, result);
        }

        [Theory, AutoFakeItEasyData]
        public async Task GetCompanyByIsin_ShouldFetchCompanyByIsinSuccessfully([Frozen] ICompanyRepository companyRepository)
        {
            // Arrange
            string isin = "Isin Test";
            A.CallTo(() => companyRepository.GetCompanyByIsinAsync(isin)).Returns(Task.FromResult(CompanyRepositoryMockData.Company));

            // Act
            var result = await companyRepository.GetCompanyByIsinAsync(isin);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(CompanyRepositoryMockData.Company, result);
        }
    }
}