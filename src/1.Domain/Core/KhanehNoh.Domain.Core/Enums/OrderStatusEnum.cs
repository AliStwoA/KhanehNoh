using System.ComponentModel.DataAnnotations;

namespace KhanehNoh.Domain.Core
{
    public enum OrderStatusEnum
    {
        [Display(Name = "منتظر پیشنهاد کارشناس")]
        WatingExpertOffer = 1,

        [Display(Name = "منتظر انتخاب کارشناس")]
        WatingForChoosingExpert = 2,

        [Display(Name = "در انتظار کارشناس")]
        WatingExpertComeToYourPlace = 3,

        [Display(Name = " آغاز کار کارشناس")]
        WorkStarted = 4,

        [Display(Name = " انجام شده")]
        WorkDoneByExpert = 5,

        [Display(Name = "پرداخت شده ")]
        WorkPaidByCustomer = 6
    }
}