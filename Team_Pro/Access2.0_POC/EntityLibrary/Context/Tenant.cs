/**
* @author udhayakumar_m
* @ reference CustomServiceLayer_MCD.pdf
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLibrary.Context
{
    public class Tenant
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("ExternalEcommSystem")]
        public long external_ecomm_system_id { get; set; }
        public virtual ExternalEcommSystem ExternalEcommSystem { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("ServiceDatabaseInfo")]
        public long service_database_id { get; set; }
        public virtual ServiceDatabaseInfo ServiceDatabaseInfo { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("ITZone")]
        public long it_zone_id { get; set; }
        public virtual ITZone ITZone { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string tenant_code { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string display_name { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="nvarchar(2000)")]
        public string tenant_url { get; set; }

        [Column(TypeName ="datetime")]
        public DateTime? created_at { get; set; }

        [Column(TypeName ="datetime")]
        public DateTime? lastupdate_at { get; set; }

        [Column(TypeName ="nvarchar(MAX)")]
        public string settings { get; set; }

        //other properties not available in the given CustomerServiceLayer_MCD.pdf file

        public virtual ICollection<LanguageToTenant> LanguageToTenant { get; set; }
        public virtual ICollection<GeographicalAreaToTenant> GeographicalAreaToTenant { get; set; }
        public virtual ICollection<AuthProviderToTenant> AuthProviderToTenant { get; set; }
        public virtual ICollection<TenantSiteMap> TenantSiteMap { get; set; }
        public virtual ICollection<TenantApplicationParameter> TenantApplicationParameter { get; set; }
        public virtual ICollection<BrandAssignmentToTenant> BrandAssignmentToTenant { get; set; }
        public virtual ICollection<UserAssignmentInTenant> UserAssignmentInTenant { get; set; }
        public virtual ICollection<Salon> Salon { get; set; }
        public virtual ICollection<AssetStorageAccountForTenant> AssetStorageAccountForTenant { get; set; }
        public virtual ICollection<TenantCMSConfiguration> TenantCMSConfiguration { get; set; }
        public virtual ICollection<EducatorTrackingActivity> EducatorTrackingActivity { get; set; }
        public virtual ICollection<UserInvitationRequest> UserInvitationRequest { get; set; }
        public virtual ICollection<Following_ActivityTracking_Notification> Following_ActivityTracking_Notification { get; set; }
        public virtual ICollection<Translations> Translations { get; set; }
        public virtual ICollection<LikeContentCompilation> LikeContentCompilation { get; set; }
        public virtual ICollection<RatingContentCompilation> RatingContentCompilation { get; set; }
        public virtual ICollection<LikeContent> LikeContent { get; set; }
        public virtual ICollection<RatingContent> RatingContent { get; set; }
        public virtual ICollection<ReviewContent> ReviewContent { get; set; }
        public virtual ICollection<ReviewContentCompilation> ReviewContentCompilation { get; set; }
        public virtual ICollection<UserBookmark> UserBookmark { get; set; }
        public virtual ICollection<Perso_LearningContentRelationship_Config> Perso_LearningContentRelationship_Config { get; set; }
        public virtual ICollection<Perso_LearningContentRelationship> Perso_LearningContentRelationship { get; set; }
        public virtual ICollection<TrendingRate_LearningContent_Config> TrendingRate_LearningContent_Config { get; set; }
        public virtual ICollection<TrendingRate_LearningContent> TrendingRate_LearningContent { get; set; }
        public virtual ICollection<TrendingRate_Hasthtag_Config> TrendingRate_Hasthtag_Config { get; set; }
        public virtual ICollection<TrendingRate_Hashtag> TrendingRate_Hashtag { get; set; }
        public virtual ICollection<ActivityTracking> ActivityTracking { get; set; }
        public virtual ICollection<UserHashtagActivityRate> UserHashtagActivityRate { get; set; }
        public virtual ICollection<UserVsUserHashtagActivityRate> UserVsUserHashtagActivityRate { get; set; }
        public virtual ICollection<TenantToLMSGroup> TenantToLMSGroup { get; set; }
        public virtual ICollection<TenantToLMSCatalog> TenantToLMSCatalog { get; set; }
        public virtual ICollection<TenantToLMSBranch> TenantToLMSBranch { get; set; }
    }
}
