//
//  CadidateData.m
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/21/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import "CadidateData.h"
#import "Candidate.h"
@implementation CadidateData
+ (instancetype)shareInstance {
    static CadidateData *_shareInstance= nil;
    static dispatch_once_t onceToken;
    dispatch_once(&onceToken, ^{
        
        _shareInstance = [[self alloc]initArray];
        
    });
    
    return _shareInstance;
}
- (id)initArray
{
    if(self = [super init])
    {
        self.arrCandidate = [NSMutableArray new];
        self.arrPotential = [NSMutableArray new];
        self.arrApplied = [NSMutableArray new];
        [self loadData];
        
    }
    return self;
}
- (void)loadData
{
    NSString * filePath =[[NSBundle mainBundle] pathForResource:@"result" ofType:@"json"];
    NSError * error;
    NSString* fileContents =[NSString stringWithContentsOfFile:filePath encoding:NSUTF8StringEncoding error:&error];
     NSDictionary * dataList = (NSDictionary *) [NSJSONSerialization
                                JSONObjectWithData:[fileContents dataUsingEncoding:NSUTF8StringEncoding]
                                options:0 error:NULL];
    NSArray *arrItems = [[dataList objectForKey:@"candidate"] objectForKey:@"items"];
    for (NSDictionary *dict in arrItems) {
        NSString *Exprience = [[dict objectForKey:@"Exprience"] substringToIndex:1];
        NSInteger intExprience = [Exprience integerValue];
        BOOL isMale = TRUE;
        NSString *Gender = [dict objectForKey:@"Gender"];
        if ([Gender isEqualToString:@"Female"]) {
            isMale = FALSE;
        }
        Candidate *candidateItem = [[Candidate alloc] initWith:[dict objectForKey:@"Name"] des:[dict objectForKey:@"Descaption"] experience:intExprience major:[dict objectForKey:@"Major"] jobTitle:[dict objectForKey:@"Job"] imageAvartar:[dict objectForKey:@"Avata"] school:[dict objectForKey:@"University"] isMale:isMale isAppliedInterview:[self getYesOrNo] idCandidate:[dict objectForKey:@"Id"] score:[[dict objectForKey:@"Score"] integerValue] phoneNumber:[dict objectForKey:@"Tel"] address:[dict objectForKey:@"Place"]];
        [self.arrCandidate addObject:candidateItem];
        
    }
}
- (BOOL) getYesOrNo
{
    int tmp = (arc4random() % 30)+1;
    if(tmp % 5 == 0)
        return YES;
    return NO;
}
- (NSMutableArray *)arrPotential
{
    NSPredicate *isApplied = [NSPredicate predicateWithFormat:@"isAppliedInterview = %d",false];
    NSArray *isbnArray = [self.arrCandidate filteredArrayUsingPredicate:isApplied];
    NSSortDescriptor *descriptor = [NSSortDescriptor sortDescriptorWithKey:@"score"
                                                                 ascending:NO];
    NSArray *results = [[isbnArray filteredArrayUsingPredicate:isApplied]
                        sortedArrayUsingDescriptors:[NSArray arrayWithObject:descriptor]];
    _arrPotential = [NSMutableArray arrayWithArray:results];
    return _arrPotential;
}
- (void)updateCadidateIsBookInterview:(BOOL)isBookInterview idCandidate:(NSString *)idCandidate
{
     NSPredicate *predicate = [NSPredicate predicateWithFormat:@"idCandidate = %@",idCandidate];
     NSArray *arrayCandidate = [self.arrCandidate filteredArrayUsingPredicate:predicate];
    if (arrayCandidate && arrayCandidate.count >0) {
        Candidate *cadidate =[arrayCandidate objectAtIndex:0];
        cadidate.isBookInterview = isBookInterview;
    }
    
}
- (Candidate *)getCandidateWithID:(NSString *)candidateID
{
    NSPredicate *predicate = [NSPredicate predicateWithFormat:@"idCandidate = %@",candidateID];
    NSArray *arrayCandidate = [self.arrCandidate filteredArrayUsingPredicate:predicate];
    Candidate *cadidate = nil;
    if (arrayCandidate && arrayCandidate.count >0) {
     cadidate = [arrayCandidate objectAtIndex:0];

    }
    return cadidate;
}
- (NSMutableArray *)arrApplied
{
    NSPredicate *isApplied = [NSPredicate predicateWithFormat:@"isAppliedInterview = %d",true];
    NSArray *isbnArray = [self.arrCandidate filteredArrayUsingPredicate:isApplied];
    NSSortDescriptor *descriptor = [NSSortDescriptor sortDescriptorWithKey:@"score"
                                                                 ascending:NO];
    NSArray *results = [[isbnArray filteredArrayUsingPredicate:isApplied]
                        sortedArrayUsingDescriptors:[NSArray arrayWithObject:descriptor]];
    _arrApplied = [NSMutableArray arrayWithArray:results];
    return _arrApplied;
}
- (NSMutableArray *)arrInterView
{
    NSPredicate *isApplied = [NSPredicate predicateWithFormat:@"isBookInterview = %d and isHasInterview = %d",true,false];
    NSArray *isbnArray = [self.arrCandidate filteredArrayUsingPredicate:isApplied];
    NSSortDescriptor *descriptor = [NSSortDescriptor sortDescriptorWithKey:@"score"
                                                                 ascending:NO];
    NSArray *results = [[isbnArray filteredArrayUsingPredicate:isApplied]
                        sortedArrayUsingDescriptors:[NSArray arrayWithObject:descriptor]];
    _arrInterView = [NSMutableArray arrayWithArray:results];
    return _arrInterView;
}
- (NSMutableArray *)arrInterViewed
{
    NSPredicate *isApplied = [NSPredicate predicateWithFormat:@"isHasInterview = %d",true];
    NSArray *isbnArray = [self.arrCandidate filteredArrayUsingPredicate:isApplied];
    NSSortDescriptor *descriptor = [NSSortDescriptor sortDescriptorWithKey:@"score"
                                                                 ascending:NO];
    NSArray *results = [[isbnArray filteredArrayUsingPredicate:isApplied]
                        sortedArrayUsingDescriptors:[NSArray arrayWithObject:descriptor]];
    _arrInterViewed = [NSMutableArray arrayWithArray:results];
    return _arrInterViewed;
}
- (void)updateCadidateAffterInterView:(NSInteger)actualScore idCandidate:(NSString *)idCandidate
{
    NSPredicate *predicate = [NSPredicate predicateWithFormat:@"idCandidate = %@",idCandidate];
    NSArray *arrayCandidate = [self.arrCandidate filteredArrayUsingPredicate:predicate];
    if (arrayCandidate && arrayCandidate.count >0) {
        Candidate *cadidate =[arrayCandidate objectAtIndex:0];
        cadidate.actualScore = actualScore;
        cadidate.isHasInterview = TRUE;
    }
    
}
@end
