using CompanyAPI.Models;
using CompanyAPI.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        /// <summary>
        /// Get All Companies.
        /// </summary>
        /// <remarks>
        /// Create get operation.
        /// Sample request: 
        ///     GET /
        /// </remarks>
        /// <response code="200"></response>
        /// <returns></returns>
        [Route("companies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<ActionResult<List<Company>>> GetAllCompanies()
        {
            return Ok(await _companyRepository.GetAllCompaniesAsync());
        }

        /// <summary>
        /// Create a company.
        /// </summary>
        /// <remarks>
        /// Create post operation.
        /// Sample request: 
        ///     POST /
        /// </remarks>
        /// <response code="200"></response>
        /// <returns></returns>
        [Route("createCompany")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> CreateCompany([FromBody] Company company)
        {
            try
            {
                return Ok(await _companyRepository.AddCompanyAsync(company));
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        /// <summary>
        /// Get company by id.
        /// </summary>
        /// <remarks>
        /// Create get operation.
        /// Sample request: 
        ///     GET /
        /// </remarks>
        /// <response code="200"></response>
        /// <ret{urns></returns>
        [Route("companyid/{companyId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<ActionResult<Company>> GetCompanyById(int companyId)
        {
            return Ok(await _companyRepository.GetCompanyByIdAsync(companyId));
        }

        /// <summary>
        /// Get Company by Isin.
        /// </summary>
        /// <remarks>
        /// Create get operation.
        /// Sample request: 
        ///     GET /
        /// </remarks>
        /// <response code="200"></response>
        /// <returns></returns>
        [Route("isin/{isin}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<ActionResult<Company>> GetCompanyByIsin(string isin)
        {
            return Ok(await _companyRepository.GetCompanyByIsinAsync(isin));
        }

        /// <summary>
        /// Update company details.
        /// </summary>
        /// <remarks>
        /// Create post operation.
        /// Sample request: 
        ///     POST /
        /// </remarks>
        /// <response code="200"></response>
        /// <returns></returns>
        [Route("updateCompany")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost]
        public async Task<ActionResult> UpdateCompany(Company company)
        {
            return Ok(await _companyRepository.UpdateCompanyAsync(company));
        }
    }
}
